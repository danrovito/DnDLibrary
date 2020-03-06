using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DnDLibrary
{
    public class FiveEHelper
    {
        public HttpClient _apiClient { get; set; }

        public void InitializeClient()
        {
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri("http://www.dnd5eapi.co/api/");
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
