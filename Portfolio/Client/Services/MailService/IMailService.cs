using System;
using System.Threading.Tasks;
using Portfolio.Shared;

namespace Portfolio.Client.Services.MailService
{
    public interface IMailService
    {
        Task<string> SendMessage(Mail mail);
    }
}