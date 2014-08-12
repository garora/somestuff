using System;
using System.Collections.Generic;
using LearningSolid.Component.Validators.Data;
using LearningSolid.Model;

namespace LearningSolid.Liskov
{
    public class LSP
    {
        public class DataBase
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

        public class LocalDB : DataBase
        {
            public override bool IsValid(ServerData data, SourceServerData sourceData)
            {
                return base.IsValid(data, sourceData);
            }

            public override void Save()
            {
                throw new Exception("Local Data should not be saved!");
            }
        }

        public void Execute()
        {
            var dataBases = new List<DataBase> {new ProdDB(), new QADB(), new LocalDB()};
            
            foreach (var dataBase in dataBases)
            {
                dataBase.Save();
            }
            
            DataBase pDataBase = new ProdDB();
            DataBase qDataBase = new QADB();
            DataBase lDataBase = new LocalDB();
            
            
        }
    }
}
