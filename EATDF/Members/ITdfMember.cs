using EATDF.Visitors;

namespace EATDF.Members;

public interface ITdfMember
{
    TdfMemberInfo TdfInfo { get; }
    bool UserSet { get; }
    bool IsSet();
    object? GetValue();
    bool Visit(ITdfVisitor visitor, Tdf parent);
    void Reset();

}
