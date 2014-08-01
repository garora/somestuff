using System.Linq;
using LearningSolid.Model;

namespace LearningSolid.Queries
{
    public class ServerDataQuery
    {
        internal IServerDataRepository Repository { get; set; }
        public ServerDataQuery(IServerDataRepository repository)
        {
            Repository = repository;
        }
        public IQueryable<ServerData> Query()
        {
            return Repository.Get().AsQueryable();
        }

        public IQueryable<ServerData> ProcessedData()
        {
            return Query().Where(d => d.IsDirty == false);
        }

    }

}
