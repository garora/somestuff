using CRUDWithWebAPI.Models;
using CRUDWithWebAPI.Models.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDWithWebAPI.Controllers
{
    public class ServerDataController : ApiController
    {
        static readonly IServerDataRepository serverDataRepository = new ServerDataRepository();

        public IEnumerable<ServerData> GetServerData()
        {
            return serverDataRepository.GetAll();
        }

        public ServerData GetServerDataById(int id)
        {
            var serverData = serverDataRepository.Get(id);

            if (serverData == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return serverData;
        }

        public IEnumerable<ServerData> GetServerDataByType(int type)
        {
            return serverDataRepository.GetAll().Where(d => d.Type == type);
        }

        public IEnumerable<ServerData> GetServerDataByIP(string ip)
        {
            return serverDataRepository.GetAll().Where(d => d.IP.ToLower() == ip.ToLower());
        }

        //Why commented this - explained in the article
        //public ServerData PostServerData(ServerData serverData)
        //{
        //    return serverDataRepository.Add(serverData);
        //}

        public HttpResponseMessage PostServerData(ServerData serverData)
        {
            serverData = serverDataRepository.Add(serverData);

            var response = Request.CreateResponse<ServerData>(HttpStatusCode.Created, serverData);

            var uri = Url.Link("DefaultApi", new { id = serverData.Id });
            response.Headers.Location = new Uri(uri);

            return response;

        }

        public void PutServerData(int id, ServerData serverData)
        {
            serverData.Id = id;

            if (!serverDataRepository.Update(serverData))
                throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        public void DeletServerData(int id)
        {
            var serverData = serverDataRepository.Get(id);

            if (serverData == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            serverDataRepository.Delete(id);
        }
    }
}
