﻿namespace ProtoFire.Frames;

public class FireFrame : IFireFrame
{
    public const byte MIN_HEADER_SIZE = 12;
    public const byte MAX_HEADER_SIZE = MIN_HEADER_SIZE + EXTRA_HEADER_SIZE_MAX; //22

    private const byte JUMBO_SIZE = sizeof(ushort); //2
    private const byte JUMBO_CONTEXT_SIZE = sizeof(ulong); //8
    private const byte SMALL_CONTEXT_SIZE = sizeof(uint); //4
    private const byte EXTRA_HEADER_SIZE_MAX = JUMBO_SIZE + JUMBO_CONTEXT_SIZE;

    [Flags]
    public enum Option
    {
        NONE = 0x0,
        JUMBO_FRAME = 0x1,
        HAS_CONTEXT = 0x2,
        IMMEDIATE = 0x4,
        JUMBO_CONTEXT = 0x8
    }

    public byte[] Frame { get; private set; }

    public FireFrame()
    {
        Frame = new byte[MAX_HEADER_SIZE];
    }

    public FireFrame(byte[] frame) : this()
    {
        if (frame.Length < MIN_HEADER_SIZE)
            throw new ArgumentException("Frame is too small");
        else if (frame.Length > MAX_HEADER_SIZE)
            throw new ArgumentException("Frame is too large");

        Buffer.BlockCopy(frame, 0, Frame, 0, frame.Length);
    }

    public void SetExtraHeader(byte[] extra)
    {
        if (extra.Length > EXTRA_HEADER_SIZE_MAX)
            throw new ArgumentException("Extra frame is too large");

        Buffer.BlockCopy(extra, 0, Frame, MIN_HEADER_SIZE, extra.Length);
    }

    public void SetExtraHeader(byte[] extra, int length)
    {
        if (extra.Length < length)
            throw new ArgumentException("extra.Length < length");

        if (length > EXTRA_HEADER_SIZE_MAX)
            throw new ArgumentException("Extra frame is too large");

        Buffer.BlockCopy(extra, 0, Frame, MIN_HEADER_SIZE, length);
    }

    public void WriteTo(Stream stream)
    {
        stream.Write(Frame, 0, HeaderSize);
    }

    public Task WriteToAsync(Stream stream)
    {
        return stream.WriteAsync(Frame, 0, HeaderSize);
    }

    public byte[] ToHeader()
    {
        byte[] header = new byte[HeaderSize];
        Buffer.BlockCopy(Frame, 0, header, 0, HeaderSize);
        return header;
    }

    public int HeaderSize
    {
        get
        {
            return MIN_HEADER_SIZE + ExtraHeaderSize;
        }
    }

    public uint Size
    {
        get
        {
            uint size = (uint)(Frame[0] << 8 | Frame[1]);
            if (OptionEnabled(Option.JUMBO_FRAME))
                size |= (uint)(Frame[12] << 24 | Frame[13] << 16);
            return size;
        }
        set
        {
            Frame[0] = (byte)(value >> 8);
            Frame[1] = (byte)value;
            if (value > ushort.MaxValue || OptionEnabled(Option.JUMBO_FRAME))
            {
                Options |= Option.JUMBO_FRAME;
                Frame[12] = (byte)(value >> 24);
                Frame[13] = (byte)(value >> 16);
            }
        }
    }

    public ushort Component
    {
        get
        {
            return (ushort)(Frame[2] << 8 | Frame[3]);
        }
        set
        {
            Frame[2] = (byte)(value >> 8);
            Frame[3] = (byte)value;
        }
    }

    public ushort Command
    {
        get
        {
            return (ushort)(Frame[4] << 8 | Frame[5]);
        }
        set
        {
            Frame[4] = (byte)(value >> 8);
            Frame[5] = (byte)value;
        }
    }

    public ushort ErrorCode
    {
        get
        {
            return (ushort)(Frame[6] << 8 | Frame[7]);
        }
        set
        {
            Frame[6] = (byte)(value >> 8);
            Frame[7] = (byte)value;
        }
    }

    public int FullErrorCode
    {
        get
        {
            ushort errCode = ErrorCode;
            if (errCode <= 0)
                return 0;

            if ((errCode & 0x4000) != 0)
                return errCode << 16; // global error
            else
                return errCode << 16 | Component; // component error
        }
    }

    public MessageType MessageType
    {
        get
        {
            return (MessageType)(Frame[8] >> 4 & 0xF);
        }
        set
        {
            if(MessageType == MessageType.Ping || MessageType == MessageType.PingReply)
                throw new InvalidOperationException("FireFrame does not support ping and ping reply message types");

            //userIndexBits    //msgType
            Frame[8] = (byte)(Frame[8] & 0xF | (byte)value << 4);
        }
    }

    public byte UserIndex
    {
        get
        {
            return (byte)(Frame[8] & 0xF);
        }
        set
        {                       //msgTypeBits           //userIndex
            Frame[8] = (byte)(Frame[8] & 0xF0 | (byte)(value & 0xF));
        }
    }

    public uint MessageNum
    {
        get
        {
            return (uint)((Frame[9] & 0xF) << 16 | Frame[10] << 8 | Frame[11]);
        }
        set
        {
            //optionBits            msgnumbits
            Frame[9] = (byte)(Frame[9] & 0xF0 | (byte)(value >> 16 & 0xF));
            Frame[10] = (byte)(value >> 8);
            Frame[11] = (byte)value;
        }
    }

    public ulong Context
    {
        get
        {
            ulong context = 0;
            if (OptionEnabled(Option.HAS_CONTEXT))
            {
                byte pos = MIN_HEADER_SIZE;

                if (OptionEnabled(Option.JUMBO_FRAME))
                    pos += JUMBO_SIZE;
                context =
                    (ulong)Frame[pos + 0] << 24 |
                    (ulong)Frame[pos + 1] << 16 |
                    (ulong)Frame[pos + 2] << 8 |
                    (ulong)Frame[pos + 3] << 0;

                if (OptionEnabled(Option.JUMBO_CONTEXT))
                {
                    context |=
                        (ulong)Frame[pos + 4] << 56 |
                        (ulong)Frame[pos + 5] << 48 |
                        (ulong)Frame[pos + 6] << 40 |
                        (ulong)Frame[pos + 7] << 32;
                }
            }
            return context;
        }
        set
        {
            byte pos = MIN_HEADER_SIZE;
            if (OptionEnabled(Option.JUMBO_FRAME))
                pos += 2;

            if (OptionEnabled(Option.HAS_CONTEXT))
            {
                Frame[pos + 0] = (byte)(value >> 24);
                Frame[pos + 1] = (byte)(value >> 16);
                Frame[pos + 2] = (byte)(value >> 8);
                Frame[pos + 3] = (byte)(value >> 0);
                if (OptionEnabled(Option.JUMBO_CONTEXT))
                {
                    Frame[pos + 4] = (byte)(value >> 56);
                    Frame[pos + 5] = (byte)(value >> 48);
                    Frame[pos + 6] = (byte)(value >> 40);
                    Frame[pos + 7] = (byte)(value >> 32);
                }
            }
        }
    }

    public Option Options
    {
        get
        {
            return (Option)(Frame[9] >> 4 & 0xF);
        }
        set
        {
            //msgNumBits          //Options
            Frame[9] = (byte)(Frame[9] & 0xF | (byte)value << 4);
        }
    }

    public ushort ExtraHeaderSize
    {
        get
        {
            ushort extraSize = OptionEnabled(Option.JUMBO_FRAME) ? JUMBO_SIZE : (ushort)0;

            if (OptionEnabled(Option.HAS_CONTEXT))
                extraSize += OptionEnabled(Option.JUMBO_CONTEXT) ? JUMBO_CONTEXT_SIZE : SMALL_CONTEXT_SIZE;

            return extraSize;
        }
    }

    public FrameType Type => FrameType.FireFrame;

    public bool OptionEnabled(Option option)
    {
        return (Options & option) == option;
    }

    public static implicit operator byte[](FireFrame frame)
    {
        return frame.ToHeader();
    }


    public FireFrame CreateResponseFrame(ushort errorCode = 0)
    {
        FireFrame respFrame = new FireFrame();
        Buffer.BlockCopy(Frame, 0, respFrame.Frame, 0, MAX_HEADER_SIZE);
        respFrame.MessageType = errorCode == 0 ? MessageType.Reply : MessageType.ErrorReply;
        respFrame.ErrorCode = errorCode;
        return respFrame;
    }



    public void Initialize(Stream stream)
    {
        // Reading the minimum header size bytes
        stream.ReadExactly(Frame, 0, MIN_HEADER_SIZE);

        // Based on the minimum read header size, we can determine if we need to read more bytes (extra header)
        int extraFrameBytesNeeded = ExtraHeaderSize;
        if (extraFrameBytesNeeded > 0)
            stream.ReadExactly(Frame, MIN_HEADER_SIZE, extraFrameBytesNeeded);

    }

    public async Task InitializeAsync(Stream stream)
    {
        // Reading the minimum header size bytes
        await stream.ReadExactlyAsync(Frame, 0, MIN_HEADER_SIZE).ConfigureAwait(false);

        // Based on the minimum read header size, we can determine if we need to read more bytes (extra header)
        int extraFrameBytesNeeded = ExtraHeaderSize;
        if (extraFrameBytesNeeded > 0)
            await stream.ReadExactlyAsync(Frame, MIN_HEADER_SIZE, extraFrameBytesNeeded).ConfigureAwait(false);
    }

    public IFireFrame CreateResponseFrame() => CreateResponseFrame(0);
    IFireFrame IFireFrame.CreateResponseFrame(ushort errorCode)
    {
        FireFrame respFrame = new FireFrame();
        Buffer.BlockCopy(Frame, 0, respFrame.Frame, 0, MAX_HEADER_SIZE);
        respFrame.MessageType = errorCode == 0 ? MessageType.Reply : MessageType.ErrorReply;
        respFrame.ErrorCode = errorCode;
        return respFrame;
    }
}