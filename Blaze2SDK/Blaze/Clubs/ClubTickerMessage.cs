using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.Clubs;

public class ClubTickerMessage : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Metadata", "mMetadata", 0xD29B6400, TdfType.String, 0, true), // TIMD
        new TdfMemberInfo("Text", "mText", 0xD29D3800, TdfType.String, 1, true), // TITX
        new TdfMemberInfo("Timestamp", "mTimestamp", 0xD33D2D00, TdfType.UInt32, 2, true), // TSTM
    ];
    private ITdfMember[] __members;

    private TdfString _metadata = new(__typeInfos[0]);
    private TdfString _text = new(__typeInfos[1]);
    private TdfUInt32 _timestamp = new(__typeInfos[2]);

    public ClubTickerMessage()
    {
        __members = [
            _metadata,
            _text,
            _timestamp,
        ];
    }

    public override Tdf CreateNew() => new ClubTickerMessage();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "ClubTickerMessage";
    public override string GetFullClassName() => "Blaze::Clubs::ClubTickerMessage";

    public string Metadata
    {
        get => _metadata.Value;
        set => _metadata.Value = value;
    }

    public string Text
    {
        get => _text.Value;
        set => _text.Value = value;
    }

    public uint Timestamp
    {
        get => _timestamp.Value;
        set => _timestamp.Value = value;
    }

}

