using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Server.Repository.MailService;
using Portfolio.Shared;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        public IMailService _mailService { get; }

        public MailController(IMailService mailService)
        {
            _mailService = mailService;

        }

        [HttpPost]
        public async Task<ActionResult<string>> PostMail(Mail mail)
        {
            return Ok(await _mailService.SendMessage(mail));
        }
    }
}