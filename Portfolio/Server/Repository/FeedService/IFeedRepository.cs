using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Server.Repository.FeedService
{
    public interface IFeedRepository
    {
        string Feeds { get; set; }
        Task<string> GetFeedRssAsync();
    }
}
