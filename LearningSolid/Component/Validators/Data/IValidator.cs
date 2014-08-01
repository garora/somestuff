using LearningSolid.Model;

namespace LearningSolid.Component.Validators.Data
{
    public interface IValidator
    {
        bool Validate(ServerData data, SourceServerData sourceData);
    }
}
