using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models{
    
    public class Afspraak
    {
        [Key]
        public int AfspraakId { get; set; }

        [Required]
        public string ClientEmail { get; set; }

        [Required]
        public string HulpverlenerEmail { get; set; } 

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime Eind { get; set; }

        public string Onderwerp { get; set; }

        public bool GoedkeuringVoogd { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}