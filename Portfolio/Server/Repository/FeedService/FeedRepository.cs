using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Portfolio.Server.Repository.FeedService
{
    public class FeedRepository : IFeedRepository
    {
        public string Feeds { get; set; }
        private readonly HttpClient _http;
        //private readonly HttpRequestMessage _request;

        public FeedRepository(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://visualstudiomagazine.com/");
            //_request = new HttpRequestMessage()
            //{
            //    Method = new HttpMethod("GET"),
            //    RequestUri = new Uri("https://www.c-sharpcorner.com/"),
            //};
            //_request.SetBrowserRequestMode(BrowserRequestMode.NoCors);
        }

        public async Task<string> GetFeedRssAsync()
        {
            var response = await _http.GetAsync("rss-feeds/news.aspx");
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
