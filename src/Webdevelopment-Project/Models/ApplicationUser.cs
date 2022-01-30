using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Webdevelopment_Project.Models;

namespace Webdevelopment_Project.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser() : base()
        {
            Chats = new List<ChatUser>();
        }
        public ICollection<ChatUser> Chats { get; set; }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get;set;}
        public string Postcode { get; set; }
        public string Huisnummer { get; set; }
        public string VoogdEmail { get; set; }
        public string HulpverlenerEmail { get; set; }
        public string Reden { get; set; }

        public Calendar Calendar { get; set; }

        public ICollection<Afspraak> Afspraken { get; set; }
        public ICollection<Intake> Intakes { get; set; }
        
        public int getLeeftijd()
        {
            return BerekenLeeftijd(GeboorteDatum);
        }

        public static int BerekenLeeftijd(DateTime geboortedatum)
        {
            var leeftijd = DateTime.Today.Year - geboortedatum.Year;

            if (DateTime.Today.DayOfYear >= geboortedatum.DayOfYear)
            {
                return leeftijd;
            }
            return leeftijd - 1;
        }
    }
}
