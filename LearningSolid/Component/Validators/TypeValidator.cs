using LearningSolid.Model;

namespace LearningSolid.Component.Validators
{
    public class TypeValidator : IDataValidator
    {
        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return data.Type == sourceData.Type;
        }
    }
}
