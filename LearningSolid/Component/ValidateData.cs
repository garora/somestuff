using LearningSolid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSolid.Component
{
    public class ValidateData
    {
        public void SyncronizeData(ServerData data, SourceServerData sourceData)
        {
            if (IsValid(data, sourceData))
            {
                //save data
            }
        }

        private bool IsValid(ServerData data, SourceServerData sourceData)
        {
            var result = false;

            if (data.Type == sourceData.Type)
                result = true;

            if (data.IP != sourceData.IP)
                result = true;

            //other checks/rules to validate incoming data

            return result;
        }
    }
}
