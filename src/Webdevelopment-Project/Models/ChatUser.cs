using System;
using System.ComponentModel.DataAnnotations;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models
{
    public class ChatUser
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
          public string Email {get; set;}

          public string BehandelaarEmail {get; set;}

          public string Bericht {get; set;}

          [DataType(DataType.Date)]
          public DateTime verzendTijd { get; set; }
    }
}