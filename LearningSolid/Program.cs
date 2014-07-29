using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid
{
    class Program
    {
        private static readonly DateTime StartDate = new DateTime(2014, 07, 01);
        private static readonly DateTime EndDate = DateTime.Now;

        static void Main(string[] args)
        {
            var repository = new ServerDataRepository(); //we can use any DI to initiate our repositories

            var processedData = GetProcessedData(repository);

            var dataMigrater = new DataMigrater(processedData,repository);

            dataMigrater.Migrate();

        }

        private static IList<ServerData> GetProcessedData(IServerDataRepository repository)
        {
            return new ServerProcessedOrRawDataQuery(repository).Query(StartDate, EndDate).ToList();
        }
    }
}
