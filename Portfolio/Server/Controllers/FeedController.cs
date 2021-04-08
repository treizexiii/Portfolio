using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Shared;
using Portfolio.Server.Repository.FeedService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly IFeedRepository _feedRepository;

        public FeedController(IFeedRepository feedRepository)
        {
           _feedRepository = feedRepository;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetRssFeed()
        {
            return Ok(await _feedRepository.GetFeedRssAsync());
        }
    }
}
