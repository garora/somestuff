using LearningSolid.Model;

namespace LearningSolid.Liskov
{
    public interface IRule
    {
        bool IsValid(ServerData data, SourceServerData sourceData);
    }
}
