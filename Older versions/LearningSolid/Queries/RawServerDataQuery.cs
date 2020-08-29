using System;
using System.Linq;
using LearningSolid.Model;

namespace LearningSolid.Queries
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
