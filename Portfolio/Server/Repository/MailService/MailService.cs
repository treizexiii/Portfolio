using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Portfolio.Shared;

namespace Portfolio.Server.Repository.MailService
{
    public class MailService : IMailService
    {
        private readonly HttpClient _http;
        private readonly IConfiguration _configuration;

        public MailService(HttpClient http, IConfiguration configuration)
        {
            _http = http;
            _configuration = configuration;
            _http.BaseAddress = new Uri("https://formspree.io");
        }

        public async Task<string> SendMessage(Mail mail)
        {
            var response = await _http.PostAsJsonAsync(_configuration.GetSection("AuthKey:Formspree").Value, mail);
            return await response.Content.ReadAsStringAsync();
        }
    }
}