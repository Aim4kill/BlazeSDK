using EATDF;
using EATDF.Members;
using EATDF.Types;

namespace Blaze3SDK.Blaze.Rooms;

public class RoomsPopulationUpdate : Tdf
{
    public class RoomAttributes : Tdf
    {
        static readonly TdfMemberInfo[] __typeInfos = [
            new TdfMemberInfo("AttributeMap", "mAttributeMap", 0x874D3200, TdfType.Map, 0, true), // ATTR
        ];
        private ITdfMember[] __members;
    
        private TdfMap<string, string> _attributeMap = new(__typeInfos[0]);
    
        public RoomAttributes()
        {
            __members = [
                _attributeMap,
            ];
        }
    
        public override Tdf CreateNew() => new RoomAttributes();
        public override ITdfMember[] GetMembers() => __members;
        public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
        public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
        public override string GetClassName() => "RoomAttributes";
        public override string GetFullClassName() => "Blaze::Rooms::RoomsPopulationUpdate::RoomAttributes";
    
        public IDictionary<string, string> AttributeMap
        {
            get => _attributeMap.Value;
            set => _attributeMap.Value = value;
        }
    
    }
    
    static readonly TdfMemberInfo[] __typeInfos = [
        new TdfMemberInfo("PopulationAttributes", "mPopulationAttributes", 0xC2FC2100, TdfType.Map, 0, true), // POPA
        new TdfMemberInfo("Population", "mPopulation", 0xC2FC2D00, TdfType.Map, 1, true), // POPM
    ];
    private ITdfMember[] __members;

    private TdfMap<uint, Blaze3SDK.Blaze.Rooms.RoomsPopulationUpdate.RoomAttributes> _populationAttributes = new(__typeInfos[0]);
    private TdfMap<uint, uint> _population = new(__typeInfos[1]);

    public RoomsPopulationUpdate()
    {
        __members = [
            _populationAttributes,
            _population,
        ];
    }

    public override Tdf CreateNew() => new RoomsPopulationUpdate();
    public override ITdfMember[] GetMembers() => __members;
    public override TdfMemberInfo[] GetMemberInfos() => __typeInfos;
    public static TdfMemberInfo[] GetTdfMemberInfos() => __typeInfos;
    public override string GetClassName() => "RoomsPopulationUpdate";
    public override string GetFullClassName() => "Blaze::Rooms::RoomsPopulationUpdate";

    public IDictionary<uint, Blaze3SDK.Blaze.Rooms.RoomsPopulationUpdate.RoomAttributes> PopulationAttributes
    {
        get => _populationAttributes.Value;
        set => _populationAttributes.Value = value;
    }

    public IDictionary<uint, uint> Population
    {
        get => _population.Value;
        set => _population.Value = value;
    }

}

