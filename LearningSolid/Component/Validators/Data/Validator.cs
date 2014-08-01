using System.Collections.Generic;
using System.Linq;
using LearningSolid.Model;

namespace LearningSolid.Component.Validators.Data
{
    public class Validator
    {
        private readonly IEnumerable<IValidator> _validators;

        public Validator(IEnumerable<IValidator> validators)
        {
            _validators = validators;
        }

        public bool Validate(ServerData data, SourceServerData sourceData)
        {
            return _validators.Any(validator => validator.Validate(data, sourceData));
        }
    }
}
