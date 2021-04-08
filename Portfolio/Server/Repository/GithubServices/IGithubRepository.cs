using Portfolio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Server.Repository.GithubServices
{
    public interface IGithubRepository
    {
        Task<Owner> FindOwner(string Name);
        Task<List<Repos>> FindRepos(string Name);
    }
}
