using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webdevelopment_Project.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string TypMessage { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}