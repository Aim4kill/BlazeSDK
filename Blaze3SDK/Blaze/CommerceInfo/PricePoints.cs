using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.CommerceInfo;

public class PricePoints : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PricePointVector", "mPricePointVector", 0xC30B0000, TdfType.List, 0, true), // PPL
        new TdfMemberInfo("IsFree", "mIsFree", 0xD23D2500, TdfType.Bool, 1, true), // TCTE
    ];
    private ITdfMember[] __members;

    private TdfList<Blaze3SDK.Blaze.CommerceInfo.PricePoint> _pricePointVector = new(__typeInfos[0]);
    private TdfBool _isFree = new(__typeInfos[1]);

    public PricePoints()
    {
        __members = [
            _pricePointVector,
            _isFree,
        ];
    }

    public override Tdf CreateNew() => new PricePoints();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "PricePoints";
    public override string GetFullClassName() => "Blaze::CommerceInfo::PricePoints";

    public IList<Blaze3SDK.Blaze.CommerceInfo.PricePoint> PricePointVector
    {
        get => _pricePointVector.Value;
        set => _pricePointVector.Value = value;
    }

    public bool IsFree
    {
        get => _isFree.Value;
        set => _isFree.Value = value;
    }

}

