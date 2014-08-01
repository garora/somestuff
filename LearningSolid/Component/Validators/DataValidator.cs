using System.Collections.Generic;
using System.Linq;
using LearningSolid.Model;

namespace LearningSolid.Component.Validators
{
    public class DataValidator
    {
        private readonly IEnumerable<IDataValidator> _validators;

        public DataValidator(IEnumerable<IDataValidator> validators)
        {
            _validators = validators;
        }

        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return _validators.Any(validator => validator.Validate(data, sourceData));
        }
    }
}
