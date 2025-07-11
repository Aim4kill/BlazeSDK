using EATDF.Visitors;

namespace EATDF.Members;

public abstract class TdfMember<T> : ITdfMember
{
    private bool _setByUser;
    private T _value;
    public bool UserSet => _setByUser;
    public TdfMemberInfo TdfInfo { get; }
    public Type Type => typeof(T);
    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            _setByUser = true;
        }
    }

    public TdfMember(TdfMemberInfo typeInfo)
    {
        TdfInfo = typeInfo;
        _value = InitValue();
        _setByUser = false;
    }
    public abstract bool IsSet();
    public abstract bool Visit(ITdfVisitor visitor, Tdf parent);
    public abstract T DefaultValue();
    public abstract T InitValue();

    public void Reset()
    {
        _value = InitValue();
    }

    public object? GetValue()
    {
        return Value;
    }
}


