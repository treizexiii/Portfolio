using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Server.Repository.GithubServices;
using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        private readonly IGithubRepository _github;

        public GithubController(IGithubRepository github)
        {
            _github = github;
        }

        [HttpGet]
        public async Task<ActionResult<Owner>> GetOwner()
        {
            return Ok(await _github.FindOwner());
        }

        [HttpGet("Repos/{marker}")]
        public async Task<ActionResult<List<Repos>>> LoadRepos(int marker)
        {
            return Ok(await _github.LoadRepos(marker));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Repos>> GetRepo(string name)
        {
            return Ok(await _github.GetRepo(name));
        }
    }
}
