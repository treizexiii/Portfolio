using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Client.Services.GithubServices
{
    public interface IGithubService
    {
        List<Repos> Repos { get; set; }
        Task<Owner> GetOwner();
        Task LoadRepos();
        Task<Repos> GetRepos(string name);
    }
}
