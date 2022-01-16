using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Webdevelopment_Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public string Voornaam { get; set; }
        // public string Achternaam { get; set; }

        // [DataType(DataType.Date)]
        // public DateTime GeboorteDatum { get; set; }
        // public string Postcode { get; set; }
        // public string Huisnummer { get; set; }
        // public string VoogdEmail { get; set; }
        // public string HulpverlenerEmail { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Afspraak> Afspraken { get; set; }
        
        // public int getLeeftijd()
        // {
        //     var leeftijd = DateTime.Today.Year - GeboorteDatum.Year;

        //     if (DateTime.Today.DayOfYear >= GeboorteDatum.DayOfYear)
        //     {
        //         return leeftijd;
        //     }
            
        //     return leeftijd - 1;
        // }

    }
}
