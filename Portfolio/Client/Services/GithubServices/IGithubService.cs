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
        event Action OnChange;
        Task<Owner> GetOwner();
        Task LoadRepos(int marker);
        Task<Repos> GetRepos(string name);
    }
}
