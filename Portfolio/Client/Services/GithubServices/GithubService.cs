using Octokit.GraphQL;
using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio.Client.Services.GithubServices
{
    public class GithubService : IGithubService
    {
        public List<Repos> Repos { get; set; } = new List<Repos>();
        private readonly HttpClient _http;
        private readonly Connection _connection;

        public GithubService(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://api.github.com");
            _http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("portfolio", "1.0"));
            _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "API_KEY");

            var productInformation = new Octokit.GraphQL.ProductHeaderValue("portfolio", "1.0");
            _connection = new Connection(productInformation, "API_KEY");
        }

        public async Task<Owner> GetOwner()
        {
            var owner = await _http.GetFromJsonAsync<Owner>("/users/treizexiii");
            return owner;
        }

        public async Task LoadRepos()
        {
            Repos = await _http.GetFromJsonAsync<List<Repos>>("/users/treizexiii/repos");
        }

        public async Task<Repos> GetRepos(string name)
        {
            var rep = Repos.FirstOrDefault(r => r.Name == name);

            var query = new Query()
                .RepositoryOwner(rep.Owner.Login)
                .Repository(rep.Name)
                .Select(r => new { r.OpenGraphImageUrl })
                .Compile();
            var result = await _connection.Run(query);
            rep.Logo = result.OpenGraphImageUrl;

            return rep;
        }

    }
}
