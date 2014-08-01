using LearningSolid.Model;

namespace LearningSolid.Component.Validators
{
    public class IPValidator : IDataValidator
    {
        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return data.IP != sourceData.IP;
        }

    }
}
