using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Client.Services.FeedServices
{
    interface IFeedService
    {
        List<Item> Feeds { get; set; }
        Task LoadFeeds();
    }
}
