using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Playgroups;

public class CreatePlaygroupRequest : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("JoinIfExists", "mJoinIfExists", 0xAAFA6E00, TdfType.Bool, 0, true), // JOIN
        new TdfMemberInfo("PlaygroupInfo", "mPlaygroupInfo", 0xC27CB000, TdfType.Struct, 1, true), // PGRP
    ];
    private ITdfMember[] __members;

    private TdfBool _joinIfExists = new(__typeInfos[0]);
    private TdfStruct<Blaze3SDK.Blaze.Playgroups.PlaygroupInfo?> _playgroupInfo = new(__typeInfos[1]);

    public CreatePlaygroupRequest()
    {
        __members = [
            _joinIfExists,
            _playgroupInfo,
        ];
    }

    public override Tdf CreateNew() => new CreatePlaygroupRequest();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "CreatePlaygroupRequest";
    public override string GetFullClassName() => "Blaze::Playgroups::CreatePlaygroupRequest";

    public bool JoinIfExists
    {
        get => _joinIfExists.Value;
        set => _joinIfExists.Value = value;
    }

    public Blaze3SDK.Blaze.Playgroups.PlaygroupInfo? PlaygroupInfo
    {
        get => _playgroupInfo.Value;
        set => _playgroupInfo.Value = value;
    }

}

