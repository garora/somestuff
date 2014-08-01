using LearningSolid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
