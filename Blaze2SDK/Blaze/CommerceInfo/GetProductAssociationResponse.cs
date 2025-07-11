using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze2SDK.Blaze.CommerceInfo;

public class GetProductAssociationResponse : Tdf
{
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("CreateDate", "mCreateDate", 0x8E393400, TdfType.String, 0, true), // CCDT
        new TdfMemberInfo("ModifiedDate", "mModifiedDate", 0x8ED93400, TdfType.String, 1, true), // CMDT
        new TdfMemberInfo("ProductName", "mProductName", 0x8F092E00, TdfType.String, 2, true), // CPDN
        new TdfMemberInfo("ProjectNumber", "mProjectNumber", 0x8F0AAE00, TdfType.String, 3, true), // CPJN
        new TdfMemberInfo("ExternalRef", "mExternalRef", 0x8F397200, TdfType.String, 4, true), // CSER
        new TdfMemberInfo("FileName", "mFileName", 0x8F39AE00, TdfType.String, 5, true), // CSFN
        new TdfMemberInfo("Name", "mName", 0x8F3B8000, TdfType.String, 6, true), // CSN
        new TdfMemberInfo("Type", "mType", 0x8F3D0000, TdfType.String, 7, true), // CST
        new TdfMemberInfo("Status", "mStatus", 0x8F3D2100, TdfType.String, 8, true), // CSTA
        new TdfMemberInfo("Uri", "mUri", 0x8F5CA900, TdfType.String, 9, true), // CURI
        new TdfMemberInfo("ProductAssociationList", "mProductAssociationList", 0xC2CCF400, TdfType.List, 10, true), // PLST
        new TdfMemberInfo("Id", "mId", 0xD6990000, TdfType.UInt64, 11, true), // UID
    ];
    private ITdfMember[] __members;

    private TdfString _createDate = new(__typeInfos[0]);
    private TdfString _modifiedDate = new(__typeInfos[1]);
    private TdfString _productName = new(__typeInfos[2]);
    private TdfString _projectNumber = new(__typeInfos[3]);
    private TdfString _externalRef = new(__typeInfos[4]);
    private TdfString _fileName = new(__typeInfos[5]);
    private TdfString _name = new(__typeInfos[6]);
    private TdfString _type = new(__typeInfos[7]);
    private TdfString _status = new(__typeInfos[8]);
    private TdfString _uri = new(__typeInfos[9]);
    private TdfList<Blaze2SDK.Blaze.CommerceInfo.ProductAssociation> _productAssociationList = new(__typeInfos[10]);
    private TdfUInt64 _id = new(__typeInfos[11]);

    public GetProductAssociationResponse()
    {
        __members = [
            _createDate,
            _modifiedDate,
            _productName,
            _projectNumber,
            _externalRef,
            _fileName,
            _name,
            _type,
            _status,
            _uri,
            _productAssociationList,
            _id,
        ];
    }

    public override Tdf CreateNew() => new GetProductAssociationResponse();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "GetProductAssociationResponse";
    public override string GetFullClassName() => "Blaze::CommerceInfo::GetProductAssociationResponse";

    public string CreateDate
    {
        get => _createDate.Value;
        set => _createDate.Value = value;
    }

    public string ModifiedDate
    {
        get => _modifiedDate.Value;
        set => _modifiedDate.Value = value;
    }

    public string ProductName
    {
        get => _productName.Value;
        set => _productName.Value = value;
    }

    public string ProjectNumber
    {
        get => _projectNumber.Value;
        set => _projectNumber.Value = value;
    }

    public string ExternalRef
    {
        get => _externalRef.Value;
        set => _externalRef.Value = value;
    }

    public string FileName
    {
        get => _fileName.Value;
        set => _fileName.Value = value;
    }

    public string Name
    {
        get => _name.Value;
        set => _name.Value = value;
    }

    public string Type
    {
        get => _type.Value;
        set => _type.Value = value;
    }

    public string Status
    {
        get => _status.Value;
        set => _status.Value = value;
    }

    public string Uri
    {
        get => _uri.Value;
        set => _uri.Value = value;
    }

    public IList<Blaze2SDK.Blaze.CommerceInfo.ProductAssociation> ProductAssociationList
    {
        get => _productAssociationList.Value;
        set => _productAssociationList.Value = value;
    }

    public ulong Id
    {
        get => _id.Value;
        set => _id.Value = value;
    }

}

