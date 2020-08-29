using System.Collections.Generic;
using ConsumeWebAPI.Models;

namespace ConsumeWebAPI.Helper
{
    public interface IServerDataRestClient
    {
        void Add(ServerDataModel serverDataModel);
        void Delete(int id);
        IEnumerable<ServerDataModel> GetAll();
        ServerDataModel GetById(int id);
        ServerDataModel GetByIP(int ip);
        ServerDataModel GetByType(int type);
        void Update(ServerDataModel serverDataModel);
    }
}
