using System;
using System.Collections.Generic;

namespace LearningSolid.Model
{
    public class SourceDataRepository : ISourceDataRepository
    {
        private readonly List<SourceServerData> _dataList = GetServerData();

        public IEnumerable<SourceServerData> Get()
        {
            return _dataList;
        }

        private static List<SourceServerData> GetServerData()
        {
            return new List<SourceServerData>(new[]
            {
                new SourceServerData
                {
                    Id = 1,
                    InitialDate= new DateTime(2014,01,01),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=1,
                    IsDirty=false,
                    Type = 1,
                    IP ="127.0.0.1"
                },

                new SourceServerData
                {
                    Id = 2,
                    InitialDate= new DateTime(2014,01,15),
                    EndDate= new DateTime(2015,01,30),
                    OrderNumber=2,
                    IsDirty=true,
                    Type=1,
                    IP ="127.0.0.1"
                }
            });
        }
    }
}