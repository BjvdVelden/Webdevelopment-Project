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

        public ApplicationUser()
        {
            Messages = new HashSet<Message>();
        }

        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        [DataType(DataType.Date)]
        public DateTime GeboorteDatum { get;set;}
        public string Postcode { get; set; }
        public string Huisnummer { get; set; }
        // public string clientEmail { get; set; }H

        public string VoogdEmail { get; set; }
        public string HulpverlenerEmail { get; set; }
        public ICollection<Afspraak> Afspraken { get; set; }
        public ICollection<Message> Messages { get; set; }

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

    public class Client: ApplicationUser {
        // public int id{get;set;}
        //  public string email{get;set;}
        public ICollection<Hulpverlener> Hulpverleners{get;set;}
    }
   
}
