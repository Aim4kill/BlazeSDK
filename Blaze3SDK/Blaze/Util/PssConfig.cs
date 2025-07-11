using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Util;

public class PssConfig : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("Address", "mAddress", 0x864CB300, TdfType.String, 0, true), // ADRS
        new TdfMemberInfo("NpCommSignature", "mNpCommSignature", 0x8F3A6700, TdfType.Blob, 1, true), // CSIG
        new TdfMemberInfo("OfferIds", "mOfferIds", 0xBE993300, TdfType.List, 2, true), // OIDS
        new TdfMemberInfo("ProjectId", "mProjectId", 0xC2AA6400, TdfType.String, 3, true), // PJID
        new TdfMemberInfo("Port", "mPort", 0xC2FCB400, TdfType.UInt32, 4, true), // PORT
        new TdfMemberInfo("InitialReportTypes", "mInitialReportTypes", 0xCB0CB400, TdfType.Enum, 5, true), // RPRT
        new TdfMemberInfo("TitleId", "mTitleId", 0xD29A6400, TdfType.UInt32, 6, true), // TIID
    ];
    private ITdfMember[] __members;

    private TdfString _address = new(__typeInfos[0]);
    private TdfBlob _npCommSignature = new(__typeInfos[1]);
    private TdfList<string> _offerIds = new(__typeInfos[2]);
    private TdfString _projectId = new(__typeInfos[3]);
    private TdfUInt32 _port = new(__typeInfos[4]);
    private TdfEnum<Blaze3SDK.Blaze.Util.PssReportTypes> _initialReportTypes = new(__typeInfos[5]);
    private TdfUInt32 _titleId = new(__typeInfos[6]);

    public PssConfig()
    {
        __members = [
            _address,
            _npCommSignature,
            _offerIds,
            _projectId,
            _port,
            _initialReportTypes,
            _titleId,
        ];
    }

    public override Tdf CreateNew() => new PssConfig();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PssConfig";
    public override string GetFullClassName() => "Blaze::Util::PssConfig";

    public string Address
    {
        get => _address.Value;
        set => _address.Value = value;
    }

    public byte[] NpCommSignature
    {
        get => _npCommSignature.Value;
        set => _npCommSignature.Value = value;
    }

    public IList<string> OfferIds
    {
        get => _offerIds.Value;
        set => _offerIds.Value = value;
    }

    public string ProjectId
    {
        get => _projectId.Value;
        set => _projectId.Value = value;
    }

    public uint Port
    {
        get => _port.Value;
        set => _port.Value = value;
    }

    public Blaze3SDK.Blaze.Util.PssReportTypes InitialReportTypes
    {
        get => _initialReportTypes.Value;
        set => _initialReportTypes.Value = value;
    }

    public uint TitleId
    {
        get => _titleId.Value;
        set => _titleId.Value = value;
    }

}

