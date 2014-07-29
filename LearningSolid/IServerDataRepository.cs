using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSolid
{
    public interface IServerDataRepository
    {
        IEnumerable<ServerData> Get();
    }
}
