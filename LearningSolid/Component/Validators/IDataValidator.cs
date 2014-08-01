using LearningSolid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid.Component
{
    public interface IDataValidator
    {
        bool Validate(ServerData data, SourceServerData sourceData);
    }
}
