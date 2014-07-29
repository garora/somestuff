using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid
{
    public class DataMigrater
    {
        private readonly IList<ServerData> _data;
        private readonly IServerDataRepository _repository;
        private readonly ILog _logger = LogManager.GetLogger(typeof(DataMigrater));
        public DataMigrater(IList<ServerData> data, IServerDataRepository repository)
        {
            _data = data;
            _repository = repository;
        }

        public void Migrate()
        {
            try
            {
                foreach (var data in _data)
                {
                    var stopWatch = Stopwatch.StartNew();

                    Migrate(data);

                    stopWatch.Stop();

                    _logger.InfoFormat("Total data {0} migrated in {1}", _data.Count, stopWatch.Elapsed);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);

                throw;
            }

        }
        private void Migrate(ServerData data)
        {
            try
            {
                //Migrate data from server to server

                _logger.InfoFormat("Migrating data with Id:{0}", data.Id);
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat("An exception occurred attempting to migrate data with Id:{0}", data.Id);

                throw;
            }
        }

    }
}
