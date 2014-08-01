using System;
using System.Collections.Generic;
using LearningSolid.Model;

namespace LearningSolid
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
                    InitialDate= new DateTime(2014,01,01),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=1,
                    IsDirty=false
                },

                new ServerData
                {
                    Id = 2,
                    InitialDate= new DateTime(2014,01,15),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=2,
                    IsDirty=true
                }
            });
        }
    }
}
