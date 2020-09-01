using dotnet_restsharp.Models;
using RestSharp;

namespace dotnet_restsharp.Services
{
    public static class RestService
    {
        public  static Users GetUsers(string nameUser)
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest($"/users/{nameUser}", Method.GET);
            var response = client.Execute<Users>(request).Data;
            return response;
        }
    }
}