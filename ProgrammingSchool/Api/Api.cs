using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSchool.Api
{
    class Api
    {
        readonly static string BaseUrl = "";
        public static dynamic user;
        public static G GET<G>(string url, List<Tuple<string, string>> paramaters, List<Tuple<string, string>> headers)
        {
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest("/" + url,Method.GET);
            client.Authenticator = new HttpBasicAuthenticator(user.NationalId, user.Password);
            foreach (var item in paramaters)
            {
                request.AddParameter(item.Item1, item.Item2);
            }
            foreach (var item in headers)
            {
                request.AddHeader(item.Item1, item.Item2);
            }
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            IRestResponse queryResult = client.Execute(request);
            G result=  JsonConvert.DeserializeObject<G>(queryResult.Content);
            return result;
            
        }
        public static IRestResponse POST<G>(string url, G data, List<Tuple<string, string>> paramaters, List<Tuple<string, string>> headers)
        {

            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/" + url, Method.POST);
            client.Authenticator = new HttpBasicAuthenticator(user.NationalId, user.Password);
            foreach (var item in paramaters)
            {
                request.AddParameter(item.Item1, item.Item2);
            }
            foreach (var item in headers)
            {
                request.AddHeader(item.Item1, item.Item2);
            }
            request.RequestFormat = DataFormat.Json;
            string json = JsonConvert.SerializeObject(data);
            request.AddJsonBody(json);
            IRestResponse response = client.Execute(request);
            return response;

        }
        public static IRestResponse PUT<G>(string url, G data, List<Tuple<string, string>> paramaters, List<Tuple<string, string>> headers)
        {

            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/" + url, Method.PUT);
            client.Authenticator = new HttpBasicAuthenticator(user.NationalId, user.Password);
            foreach (var item in paramaters)
            {
                request.AddParameter(item.Item1, item.Item2);
            }
            foreach (var item in headers)
            {
                request.AddHeader(item.Item1, item.Item2);
            }
            string json = JsonConvert.SerializeObject(data);
            request.AddJsonBody(json);
            IRestResponse response = client.Execute(request);
            return response;

        }
        public static IRestResponse DELETE(string url, string id)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("/" + url,Method.DELETE);
            client.Authenticator = new HttpBasicAuthenticator(user.NationalId, user.Password);
            request.AddParameter("id", id);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
