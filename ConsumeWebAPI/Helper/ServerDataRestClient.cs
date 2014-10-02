using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using ConsumeWebAPI.Models;
using RestSharp;

namespace ConsumeWebAPI.Helper
{
    public class ServerDataRestClient : IServerDataRestClient
    {
        private readonly RestClient _client;
        private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public ServerDataRestClient()
        {
            _client = new RestClient(_url);
        }

        public IEnumerable<ServerDataModel> GetAll()
        {
            var request = new RestRequest("api/serverdata", Method.GET) {RequestFormat = DataFormat.Json};

            var response = _client.Execute<List<ServerDataModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public ServerDataModel GetById(int id)
        {
            var request = new RestRequest("api/serverdata/{id}", Method.GET) {RequestFormat = DataFormat.Json};

            request.AddParameter("id", id, ParameterType.UrlSegment);
            
            var response = _client.Execute<ServerDataModel>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public ServerDataModel GetByType(int type)
        {
            var request = new RestRequest("api/serverdata/type/{datatype}", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddParameter("datatype", type, ParameterType.UrlSegment);

            var response = _client.Execute<ServerDataModel>(request);

            return response.Data;
        }

        public ServerDataModel GetByIP(int ip)
        {
            var request = new RestRequest("api/serverdata/ip/{ip}", Method.GET) {RequestFormat = DataFormat.Json};
            request.AddParameter("ip", ip, ParameterType.UrlSegment);

            var response = _client.Execute<ServerDataModel>(request);

            return response.Data;
        }

        public void Add(ServerDataModel serverData)
        {
            var request = new RestRequest("api/serverdata", Method.POST) {RequestFormat = DataFormat.Json};
            request.AddBody(serverData);

            var response = _client.Execute<ServerDataModel>(request);

            if (response.StatusCode != HttpStatusCode.Created)
                throw new Exception(response.ErrorMessage);

        }

        public void Update(ServerDataModel serverData)
        {
            var request = new RestRequest("api/serverdata/{id}", Method.PUT) {RequestFormat = DataFormat.Json};
            request.AddParameter("id", serverData.Id, ParameterType.UrlSegment);
            request.AddBody(serverData);

            var response = _client.Execute<ServerDataModel>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new Exception(response.ErrorMessage);
        }

        public void Delete(int id)
        {
            var request = new RestRequest("api/serverdata/{id}", Method.DELETE);
            request.AddParameter("id", id, ParameterType.UrlSegment);
           
            var response = _client.Execute<ServerDataModel>(request);

            if (response.StatusCode == HttpStatusCode.NotFound)
                throw new Exception(response.ErrorMessage);
        }
    }
}