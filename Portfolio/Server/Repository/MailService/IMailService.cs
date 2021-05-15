using System.Threading.Tasks;
using Portfolio.Shared;

namespace Portfolio.Server.Repository.MailService
{
    public interface IMailService
    {
        Task<string> SendMessage(Mail mail);
    }
}