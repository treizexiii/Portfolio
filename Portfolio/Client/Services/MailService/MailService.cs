using System.Net.Http;
using System;
using System.Net;
using System.Net.Mail;
using Portfolio.Shared;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Portfolio.Client.Services.MailService
{
    public class MailService : IMailService
    {
        private readonly HttpClient _http;

        public MailService(HttpClient http)
        {
            _http = http;
            _http.BaseAddress = new Uri("https://formspree.io/");
        }

        public async Task<string> SendMessage(Mail mail) {
            var response = await _http.PostAsJsonAsync("f/mjvjvzjj", mail);
            return await response.Content.ReadAsStringAsync();
        }
    }
}