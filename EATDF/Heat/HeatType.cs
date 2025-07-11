namespace EATDF.Heat;

public enum HeatType : byte
{
    Struct = 0x00,
    String = 0x01,
    Int8 = 0x02,
    UInt8 = 0x03,
    Int16 = 0x04,
    UInt16 = 0x05,
    Int32 = 0x06,
    UInt32 = 0x07,
    Int64 = 0x08,
    UInt64 = 0x09,
    Array = 0x0A,
    Blob = 0x0B,
    Map = 0x0C,
    Union = 0x0D,
}
