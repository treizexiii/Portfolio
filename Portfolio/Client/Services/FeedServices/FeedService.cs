using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Portfolio.Client.Services.FeedServices
{
    public class FeedService : IFeedService
    {
        private readonly HttpClient _http;

        public List<Item> Feeds { get; set; } = new List<Item>();

        public FeedService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadFeeds()
        {
            var response = await _http.GetStringAsync("api/Feed/");
            XmlSerializer serializer = new XmlSerializer(typeof(Rss));
            using (StringReader reader = new StringReader(response))
            {
               var rss = (Rss)serializer.Deserialize(reader);
               Feeds = rss.Channel.Item;
            }
        }
    }
}
