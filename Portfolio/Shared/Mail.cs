using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Shared
{
    public class Mail
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        public string Subject { get; set; }
        [MaxLength(255)]
        [Required]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToLocalTime();
    }
}