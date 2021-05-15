using Microsoft.Extensions.Configuration;
using Octokit.GraphQL;
using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio.Server.Repository.GithubServices
{
    public class GithubRepository : IGithubRepository
    {
        private readonly HttpClient _http;
        private readonly IConfiguration _configuration;
        private readonly Connection _connection;

        public GithubRepository(HttpClient http, IConfiguration configuration)
        {
            _http = http;
            _configuration = configuration;
            _http.BaseAddress = new Uri("https://api.github.com");
            _http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("portfolio", "1.0"));
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", _configuration.GetSection("AuthKey:Github").Value);

            var productInformation = new Octokit.GraphQL.ProductHeaderValue("portfolio", "1.0");
            _connection = new Connection(productInformation, _configuration.GetSection("AuthKey:Github").Value);
        }

        public async Task<Owner> FindOwner()
        {
            return await _http.GetFromJsonAsync<Owner>("/users/treizexiii");
        }

        public async Task<List<Repos>> LoadRepos(int marker)
        {
            return await _http.GetFromJsonAsync<List<Repos>>("/users/treizexiii/repos?sort=created&per_page=6&page=" + marker);
        }

        public async Task<Repos> GetRepo(string name)
        {
            var repos = await _http.GetFromJsonAsync<Repos>("/repos/treizexiii/" + name);

                var query = new Query()
                    .RepositoryOwner(repos.Owner.Login)
                    .Repository(repos.Name)
                    .Select(r => new { r.OpenGraphImageUrl })
                    .Compile();
                var result = await _connection.Run(query);
                repos.Logo = result.OpenGraphImageUrl;

            return repos;
        }
    }
}
