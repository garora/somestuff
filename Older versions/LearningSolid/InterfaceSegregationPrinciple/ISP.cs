using LearningSolid.Liskov;

namespace LearningSolid.InterfaceSegregationPrinciple
{
    public class ISP
    {
        public class DataBaseReport : IReport
        {
            public void Save()
            {
                var dataBase = new LSP.DataBase();
                dataBase.Save();
            }

            public void Generate()
            {
                //implement report generation logic here
            }
        }

        public class UATDB : DataBaseReport
        {
            //class members

        }

        public void Execute()
        {
            //Old client implementation
            IRepository repository = new LSP.DataBase();
            repository.Save();

            
            //implementation for new clients who want to generate report
            IReport report = new DataBaseReport();
            report.Generate();
        }
    }
}
