namespace EATDF.Heat2;

public enum Heat2Type : byte
{
    Integer = 0x0,
    String = 0x1,
    Binary = 0x2,
    Struct = 0x3,
    List = 0x4,
    Map = 0x5,
    Union = 0x6,
    Variable = 0x7,
    BlazeObjectType = 0x8,
    BlazeObjectId = 0x9,
    Float = 0xA,
    TimeValue = 0xB,
}
