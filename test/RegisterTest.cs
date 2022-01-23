using System;
using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Webdevelopment_Project.Models;
using Xunit;

namespace test
{
    public class RegisterTest
    {

        private static ApplicationUser createRegister()
        {
            ApplicationUser register = new ApplicationUser{
                Voornaam = "Younes",
                Achternaam = "El Bali",
                GeboorteDatum = DateTime.Parse("01-01-2000"),
                Postcode = "2873HU",
                Huisnummer = "2810KI",
                HulpverlenerEmail = "hulpoverlener@gmail.com"
            };
            return register;
        }
        
        [Fact]
        public void RegisterAccountTest() 
        {
            ApplicationUser register = createRegister();
            
            Assert.NotNull(register);
            Assert.Equal("Younes", register.Voornaam);
            Assert.Null(register.VoogdEmail);
        }
    }
}