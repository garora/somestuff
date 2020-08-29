using System.Collections.Generic;
using System.Linq;
using LearningSolid.Component.Validators.Data;
using LearningSolid.Model;

namespace LearningSolid.Liskov
{
    public class LSP
    {
        public class DataBase : IRule, IRepository
        {
            public virtual bool IsValid(ServerData data, SourceServerData sourceData)
            {
                return new Validator(new List<IValidator>()).Validate(data, sourceData);
            }

            public virtual void Save()
            {
                //logic to save data
            }
        }

        public class ProdDB : DataBase
        {
            public override bool IsValid(ServerData data, SourceServerData sourceData)
            {
                return base.IsValid(data, sourceData);
            }

            public override void Save()
            {
                //logic to save data
                base.Save();
            }
        }

        public class QADB : DataBase
        {
            public override bool IsValid(ServerData data, SourceServerData sourceData)
            {
                return base.IsValid(data, sourceData);
            }

            public override void Save()
            {
                //logic to save data
                base.Save();
            }
        }

        public class LocalDB : IRule
        {
            public bool IsValid(ServerData data, SourceServerData sourceData)
            {
                return new Validator(new List<IValidator>()).Validate(data, sourceData);
            }
        }

        public void Execute(ServerData data, SourceServerData sourceData)
        {
            var dataBases = new List<IRepository> { new ProdDB(), new QADB() };

            foreach (var dataBase in dataBases.Where(dataBase => ((IRule)dataBase).IsValid(data, sourceData)))
            {
                dataBase.Save();
            }
        }
    }
}
