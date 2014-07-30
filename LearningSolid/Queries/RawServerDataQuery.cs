using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid
{
    public class ServerProcessedOrRawDataQuery
    {
        internal IServerDataRepository Repository { get; set; }
        public ServerProcessedOrRawDataQuery(IServerDataRepository repository)
        {
           Repository = repository;
        }
        public IQueryable<ServerData> Query(DateTime startDate, DateTime endDate)
        {
            return new ServerDataQuery(Repository).ProcessedData()
                .Where(d => d.InitialDate <= endDate && d.EndDate >= startDate);
        }


    }
}
