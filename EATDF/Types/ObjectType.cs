
namespace EATDF.Types;

public struct ObjectType
{
    public ushort Component { get; set; }
    public ushort Type { get; set; }

    public ObjectType()
    {
        Component = 0;
        Type = 0;
    }

    public ObjectType(ushort component, ushort type)
    {
        Component = component;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Component}/{Type}";
    }

    public object? GetValue()
    {
        return this;
    }

    public void SetValue(object value)
    {
        ObjectType obj = (ObjectType)value;
        Component = obj.Component;
        Type = obj.Type;
    }

    public object? GetDefaultValue()
    {
        return new ObjectType();
    }

    public object? GetInitValue()
    {
        return new ObjectType();
    }
}
