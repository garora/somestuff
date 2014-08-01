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
            IList<IDataValidator> validators = new List<IDataValidator>();
            validators.Add(new IPValidator());
            validators.Add(new TypeValidator());

            return IsDataValid(validators, data, sourceData);
        }

        private bool IsDataValid(IList<IDataValidator> validators, ServerData data, SourceServerData sourceData)
        {
            foreach (var validator in validators)
            {
                if (validator.Validate(data, sourceData))
                    return true;
            }
            return false;
        }
    }
}
