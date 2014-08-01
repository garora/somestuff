using LearningSolid.Model;

namespace LearningSolid.Component.Validators
{
    public interface IDataValidator
    {
        bool Validate(ServerData data, SourceServerData sourceData);
    }
}
