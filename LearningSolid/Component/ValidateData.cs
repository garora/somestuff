using LearningSolid.Component.Validators;
using LearningSolid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid.Component
{
    public class ValidateData
    {
        public bool IsDataValidated(ServerData data, SourceServerData sourceData)
        {
            var validators = new List<IDataValidator>
            {
                new IPValidator(),
                new TypeValidator()
            };

            return IsDataValid(validators, data, sourceData);
        }

        private bool IsDataValid(IEnumerable<IDataValidator> validators, ServerData data, SourceServerData sourceData)
        {
            return validators.Any(validator => validator.Validate(data, sourceData));
        }
    }
}
