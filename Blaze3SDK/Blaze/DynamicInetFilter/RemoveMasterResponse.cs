using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class RemoveMasterResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MapVersion", "mMapVersion", 0xB7697200, TdfType.UInt32, 0, true), // MVER
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _mapVersion = new(__typeInfos[0]);

    public RemoveMasterResponse()
    {
        __members = [
            _mapVersion,
        ];
    }

    public override Tdf CreateNew() => new RemoveMasterResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RemoveMasterResponse";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::RemoveMasterResponse";

    public uint MapVersion
    {
        get => _mapVersion.Value;
        set => _mapVersion.Value = value;
    }

}

