using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.DynamicInetFilter;

public class AddMasterResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("MapVersion", "mMapVersion", 0xB7697200, TdfType.UInt32, 0, true), // MVER
        new TdfMemberInfo("RowId", "mRowId", 0xCA990000, TdfType.UInt32, 1, true), // RID
    ];
    private ITdfMember[] __members;

    private TdfUInt32 _mapVersion = new(__typeInfos[0]);
    private TdfUInt32 _rowId = new(__typeInfos[1]);

    public AddMasterResponse()
    {
        __members = [
            _mapVersion,
            _rowId,
        ];
    }

    public override Tdf CreateNew() => new AddMasterResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "AddMasterResponse";
    public override string GetFullClassName() => "Blaze::DynamicInetFilter::AddMasterResponse";

    public uint MapVersion
    {
        get => _mapVersion.Value;
        set => _mapVersion.Value = value;
    }

    public uint RowId
    {
        get => _rowId.Value;
        set => _rowId.Value = value;
    }

}

