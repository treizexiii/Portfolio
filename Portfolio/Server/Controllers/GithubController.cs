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

        [HttpGet("{name}")]
        public async Task<ActionResult<Owner>> GetOwner(string name)
        {
            return Ok(await _github.FindOwner(name));
        }

        [HttpGet("Repos/{repos}")]
        public async Task<ActionResult<List<Repos>>> GetRepos(string repos)
        {
            return Ok(await _github.FindRepos(repos));
        }
    }
}
