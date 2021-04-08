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
        private readonly Connection _connection;

        public GithubRepository(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://api.github.com");
            _http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("portfolio", "1.0"));
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "API_KEY");

            var productInformation = new Octokit.GraphQL.ProductHeaderValue("portfolio", "1.0");
            _connection = new Connection(productInformation, "API_KEY");
        }

        public async Task<Owner> FindOwner(string name)
        {
            return await _http.GetFromJsonAsync<Owner>("/users/" + name);
        }

        public async Task<List<Repos>> FindRepos(string name)
        {
            var repos = await _http.GetFromJsonAsync<List<Repos>>("/users/" + name + "/repos");
            foreach (var item in repos)
            {
                var query = new Query().RepositoryOwner(item.Owner.Login).Repository(item.Name)
                    .Select(r => new { r.OpenGraphImageUrl }).Compile();

                var result = await _connection.Run(query);
                item.Logo = result.OpenGraphImageUrl;
            }

            return repos;
        }
    }
}
