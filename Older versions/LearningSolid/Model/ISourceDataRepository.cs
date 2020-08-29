using System.Collections.Generic;

namespace LearningSolid.Model
{
    public interface ISourceDataRepository
    {
        IEnumerable<SourceServerData> Get();
    }
}