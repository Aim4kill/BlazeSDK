using ProtoFire.Captures.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures;

public class ProtoFireCapture : IDisposable
{
    bool _captureMode;
    bool _ownsStream;
    bool _disposed;
    Exception? _lastException;
    Stream _stream;
    object _lock = new object();

    /// <summary>
    /// Constructor for capture or replay mode
    /// </summary>
    /// <param name="stream">The stream to capture or replay</param>
    /// <param name="captureMode">True for capture mode, false for replay mode</param>
    /// <exception cref="InvalidOperationException">Thrown if stream is not readable for replay mode or not writable for capture mode</exception>
    public ProtoFireCapture(Stream stream, bool ownsStream, bool captureMode)
    {
        ArgumentNullException.ThrowIfNull(stream, nameof(stream));

        _captureMode = captureMode;
        _ownsStream = ownsStream;
        _stream = stream;

        if (_captureMode && !_stream.CanWrite)
            throw new InvalidOperationException("Stream must be writable for capture mode");

        if (!_captureMode && !_stream.CanRead)
            throw new InvalidOperationException("Stream must be readable for replay mode");
    }

    public void WriteRecord(CaptureRecord record)
    {
        ArgumentNullException.ThrowIfNull(record, nameof(record));

        if (!_captureMode)
            throw new InvalidOperationException("Cannot write record in replay mode");

        lock (_lock)
        {
            _stream.WriteByte((byte)record.RecordType);
            record.WriteTo(_stream);
            _stream.Flush();
        }
    }

    public CaptureRecord? ReadRecord()
    {
        if (_captureMode)
            throw new InvalidOperationException("Cannot read record in capture mode");

        if (_lastException != null)
            throw new InvalidOperationException("Cannot read new record after last read which resulted in failure. Check inner exception.", _lastException);
        
        if (_stream.Position == _stream.Length)
            return null;

        lock (_lock)
        {
            try
            {
                RecordType recordType = (RecordType)_stream.ReadByte();
                CaptureRecord record = recordType switch
                {
                    RecordType.Metadata => new MetadataRecord(),
                    RecordType.Packet => new PacketRecord(),
                    _ => throw new InvalidOperationException($"Unknown record type {recordType}")
                };

                record.ReadFrom(_stream);
                return record;
            }
            catch (Exception ex)
            {
                _lastException = ex;
                throw;
            }
        }
    }

    public void Dispose()
    {
        if (_disposed)
            return;
        _disposed = true;

        if (_ownsStream)
            _stream.Dispose();
    }
}
