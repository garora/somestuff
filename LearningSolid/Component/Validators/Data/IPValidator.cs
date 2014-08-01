using LearningSolid.Model;

namespace LearningSolid.Component.Validators.Data
{
    public class IPValidator : IValidator
    {
        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return data.IP != sourceData.IP;
        }

    }
}
