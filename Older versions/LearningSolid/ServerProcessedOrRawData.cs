using System;
using System.Collections.Generic;
using System.Linq;
using LearningSolid.Component.Validators.Data;
using LearningSolid.Model;
using LearningSolid.Queries;

namespace LearningSolid
{
    public class ServerProcessedOrRawData
    {
        private readonly IServerDataRepository _repository;
        public ServerProcessedOrRawData(IServerDataRepository repository)
        {
            _repository = repository;
        }

        public IList<ServerData> GetServerData(DateTime startDate, DateTime endDate)
        {
            var validData = new List<ServerData>();

            var serverData = ServerData(startDate, endDate);

            var sourceServerData = SourceServerData();

            foreach (var data in serverData)
            {
                var sourceData = sourceServerData.FirstOrDefault(s => s.RecordIdentifier == data.RecordIdentifier);

                if (IsValid(data, sourceData))
                    validData.Add(data);
            }

            return validData;
        }

        private IEnumerable<ServerData> ServerData(DateTime startDate, DateTime endDate)
        {
            return new ServerProcessedOrRawDataQuery(_repository).Query(startDate, endDate);
        }
        private static IQueryable<SourceServerData> SourceServerData()
        {
            return new SourceServerDataQuery(new SourceDataRepository()).Query();
        }
        private bool IsValid(ServerData data, SourceServerData sourceData)
        {
            var validators = new List<IValidator>
            {
                new IPValidator(),
                new TypeValidator()
            };

            return new Validator(validators).Validate(data, sourceData);
        }
    }
}