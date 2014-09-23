using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Configuration;
using System.Net;
using consumewebapiusingrestsharp.Models;

namespace consumewebapiusingrestsharp.Helper
{
    public class ServerDataRestClient : consumewebapiusingrestsharp.Helper.IServerDataRestClient
    {
        private RestClient client;
        private string url = ConfigurationManager.AppSettings["webapibaseurl"].ToString();

        public ServerDataRestClient()
        {
            client = new RestClient(url);
        }

        public IEnumerable<ServerData> GetAll()
        {
            var request = new RestRequest("api/serverdata", Method.GET);

            var response = client.Execute<List<ServerData>>(request);

            request.OnBeforeDeserialization = reponse => { response.ContentType = "application/json"; };

            return response.Data;
        }

        public ServerData GetById(int id)
        {
            var request = new RestRequest("api/serverdata", Method.GET);
            request.AddParameter("id", id);

            var response = client.Execute<ServerData>(request);

            return response.Data;
        }

        public ServerData GetByType(int type)
        {
            var request = new RestRequest("api/serverdata/type", Method.GET);
            request.AddParameter("datatype", type);

            var response = client.Execute<ServerData>(request);

            return response.Data;
        }

        public ServerData GetByIP(int ip)
        {
            var request = new RestRequest("api/serverdata/ip", Method.GET);
            request.AddParameter("ip", ip);

            var response = client.Execute<ServerData>(request);

            return response.Data;
        }

        public void Add(ServerData serverData)
        {
            var request = new RestRequest("api/serverdata", Method.POST);
            request.AddBody(serverData);

            var response = client.Execute<ServerData>(request);

            if (response.StatusCode != HttpStatusCode.Created)
                throw new Exception(response.ErrorMessage);

        }

        public void Update(ServerData serverData)
        {
            var request = new RestRequest("api/serverdata", Method.PUT);
            request.AddParameter("id", serverData.Id);
            request.AddBody(serverData);

            var response = client.Execute<ServerData>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new Exception(response.ErrorMessage);
        }

        public void Delete(int id)
        {
            var request = new RestRequest("api/serverdata", Method.DELETE);
            request.AddParameter("id", id);

            var response = client.Execute<ServerData>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new Exception(response.ErrorMessage);
        }
    }
}