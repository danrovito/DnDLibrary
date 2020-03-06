using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DnDLibrary
{
    public class FiveEHelper
    {
        public HttpClient ApiClient { get; set; }

        public void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://www.dnd5eapi.co/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
