using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.GameManager;

public class GameAttributeCensusData : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("AttributeName", "mAttributeName", 0x874D2E00, TdfType.String, 0, true), // ATTN
        new TdfMemberInfo("Attributevalue", "mAttributevalue", 0x874D3600, TdfType.String, 1, true), // ATTV
        new TdfMemberInfo("NumOfGames", "mNumOfGames", 0xBAF9A700, TdfType.UInt32, 2, true), // NOFG
        new TdfMemberInfo("NumOfPlayers", "mNumOfPlayers", 0xBAF9B000, TdfType.UInt32, 3, true), // NOFP
    ];
    private ITdfMember[] __members;

    private TdfString _attributeName = new(__typeInfos[0]);
    private TdfString _attributevalue = new(__typeInfos[1]);
    private TdfUInt32 _numOfGames = new(__typeInfos[2]);
    private TdfUInt32 _numOfPlayers = new(__typeInfos[3]);

    public GameAttributeCensusData()
    {
        __members = [
            _attributeName,
            _attributevalue,
            _numOfGames,
            _numOfPlayers,
        ];
    }

    public override Tdf CreateNew() => new GameAttributeCensusData();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GameAttributeCensusData";
    public override string GetFullClassName() => "Blaze::GameManager::GameAttributeCensusData";

    public string AttributeName
    {
        get => _attributeName.Value;
        set => _attributeName.Value = value;
    }

    public string Attributevalue
    {
        get => _attributevalue.Value;
        set => _attributevalue.Value = value;
    }

    public uint NumOfGames
    {
        get => _numOfGames.Value;
        set => _numOfGames.Value = value;
    }

    public uint NumOfPlayers
    {
        get => _numOfPlayers.Value;
        set => _numOfPlayers.Value = value;
    }

}

