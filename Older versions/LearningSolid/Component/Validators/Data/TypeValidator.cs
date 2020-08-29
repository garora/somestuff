using LearningSolid.Model;

namespace LearningSolid.Component.Validators.Data
{
    public class TypeValidator : IValidator
    {
        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return data.Type == sourceData.Type;
        }
    }
}
