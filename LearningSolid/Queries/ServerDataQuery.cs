using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid
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
            return Repository.Get().AsQueryable<ServerData>();
        }

        public IQueryable<ServerData> ProcessedData()
        {
            return Query().Where(d => d.IsDirty == false);
        }

    }

}
