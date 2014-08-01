using System;
using System.Collections.Generic;

namespace LearningSolid.Model
{
    class ServerDataRepository : IServerDataRepository
    {
        private readonly List<ServerData> _dataList = GetServerData();

        public IEnumerable<ServerData> Get()
        {
            return _dataList;
        }

        private static List<ServerData> GetServerData()
        {
            return new List<ServerData>(new[]
            {
                new ServerData
                {
                    Id = 1,
                    InitialDate = new DateTime(2014, 01, 01),
                    EndDate = new DateTime(2015, 01, 30),
                    OrderNumber = 1,
                    IsDirty = false,
                    Type = 1,
                    IP = "127.0.0.0"
                },

                new ServerData
                {
                    Id = 2,
                    InitialDate = new DateTime(2014, 01, 15),
                    EndDate = new DateTime(2015, 01, 30),
                    OrderNumber = 2,
                    IsDirty = true,
                    Type = 1,
                    IP = "127.0.0.0"
                }
            });
        }
    }
}
