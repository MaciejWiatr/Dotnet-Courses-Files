using System;
using System.Net.Http;

namespace ConstAndReadonly
{

    class ApiClient
    {
        private readonly string baseUrl = "https://example.com";
        private const string getUsersEndpoint = "/api/users";
        private readonly HttpClient httpClient = new HttpClient();
        private int defaultPort = 80;

        public ApiClient(string _baseurl)
        {
            baseUrl = _baseurl;
        }

        public void GetUsers()
        {
            var getUsersUri = $"{baseUrl}{getUsersEndpoint}";

            httpClient.GetAsync(getUsersUri);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
