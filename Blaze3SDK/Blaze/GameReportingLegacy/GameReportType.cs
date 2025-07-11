using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameReportingLegacy;

public class GameReportType : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeTypes", "mAttributeTypes", 0x874E7000, TdfType.List, 0, true), // ATYP
        new TdfMemberInfo("GameTypeId", "mGameTypeId", 0x9F4A6400, TdfType.UInt32, 1, true), // GTID
        new TdfMemberInfo("GameTypeName", "mGameTypeName", 0x9F4BA100, TdfType.String, 2, true), // GTNA
    ];
    private ITdfMember[] __members;

    private TdfList<string> _attributeTypes = new(__typeInfos[0]);
    private TdfUInt32 _gameTypeId = new(__typeInfos[1]);
    private TdfString _gameTypeName = new(__typeInfos[2]);

    public GameReportType()
    {
        __members = [
            _attributeTypes,
            _gameTypeId,
            _gameTypeName,
        ];
    }

    public override Tdf CreateNew() => new GameReportType();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameReportType";
    public override string GetFullClassName() => "Blaze::GameReportingLegacy::GameReportType";

    public IList<string> AttributeTypes
    {
        get => _attributeTypes.Value;
        set => _attributeTypes.Value = value;
    }

    public uint GameTypeId
    {
        get => _gameTypeId.Value;
        set => _gameTypeId.Value = value;
    }

    public string GameTypeName
    {
        get => _gameTypeName.Value;
        set => _gameTypeName.Value = value;
    }

}

