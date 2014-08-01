using System.Collections.Generic;

namespace LearningSolid.Model
{
    public interface IServerDataRepository
    {
        IEnumerable<ServerData> Get();
    }
}
