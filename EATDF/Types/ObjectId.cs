
namespace EATDF.Types;

public struct ObjectId
{
    public long Id { get; set; }
    public ObjectType Type { get; set; }

    public ObjectId()
    {
        Id = 0;
        Type = new ObjectType();
    }

    public ObjectId(ObjectType type)
    {
        Id = 0;
        Type = type;
    }

    public ObjectId(long id)
    {
        Id = id;
        Type = new ObjectType();
    }

    public ObjectId(long id, ObjectType type)
    {
        Id = id;
        Type = type;
    }

    public ObjectId(long id, ushort component, ushort type)
    {
        Id = id;
        Type = new ObjectType(component, type);
    }

    //TODO: make sure the output order is correct, maybe in reality it is $"{Id}/{Type}"
    public override string ToString()
    {
        return $"{Type}/{Id}";
    }

    public object? GetValue()
    {
        return this;
    }

    public void SetValue(object value)
    {
        ObjectId obj = (ObjectId)value;
        Id = obj.Id;
        Type = obj.Type;
    }

    public object? GetDefaultValue()
    {
        return new ObjectType();
    }
}
