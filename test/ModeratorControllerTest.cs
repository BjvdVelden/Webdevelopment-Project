using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Webdevelopment_Project.Controllers;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Infrastructure.Respository;
using Webdevelopment_Project.Models;
using Xunit;

namespace test
{
    public class ModeratorControllerTest
    {
        private ApplicationDbContext context;

        public static Mock<UserManager<ApplicationUser>> MockUserManager()
        {
            var store = new Mock<IUserStore<ApplicationUser>>();
            var mgr = new Mock<UserManager<ApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
            mgr.Object.UserValidators.Add(new UserValidator<ApplicationUser>());
            mgr.Object.PasswordValidators.Add(new PasswordValidator<ApplicationUser>());

            mgr.Setup(x => x.DeleteAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);
            mgr.Setup(x => x.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            return mgr;
        }

        public static Mock<RoleManager<IdentityRole>> GetRoleManagerMock()  
        {  
                    var store = new Mock<IRoleStore<IdentityRole>>();
                    var usr = new Mock<RoleManager<IdentityRole>>(store.Object, null, null, null, null);
                    usr.Object.RoleValidators.Add(new RoleValidator<IdentityRole>());

                    usr.Setup(x => x.DeleteAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Success);
                    usr.Setup(x => x.CreateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Success);
                    usr.Setup(x => x.UpdateAsync(It.IsAny<IdentityRole>())).ReturnsAsync(IdentityResult.Success);

                    return usr;
        }  

        private static ApplicationUser CreateApplicationUser()
        {
            ApplicationUser appUser = new ApplicationUser{
                Voornaam = "Serdin",
                Achternaam = "Durmishi",
                GeboorteDatum = DateTime.Parse("01/01/2000"),
                Postcode = "8729JD",
                Huisnummer = "5",
                VoogdEmail = " ",
                HulpverlenerEmail = "hulpverlener1@gmail.com"
            };
            return appUser;
        }

        [Fact]
        public void BlockTest(){

            var user = MockUserManager().Object.GetUsersInRoleAsync("Client").ToString();
            var contextUser = new Claim(ClaimTypes.Role, "Zelfhulpgroep_ban");

            var mgr = MockUserManager();
            var usr = GetRoleManagerMock();

            ModeratorController moderator = new ModeratorController(mgr.Object, usr.Object, context);

            var appUser = CreateApplicationUser();

            var s = moderator.Blokkeren(appUser.Id);

            Assert.NotNull(s);
            Assert.Equal("Zelfhulpgroep_ban", contextUser.Value);
            Assert.NotEqual("Client", contextUser.Value);
        }

        [Fact]
        public void UnBlockTest(){

            var user = MockUserManager().Object.GetUsersInRoleAsync("Client").ToString();
            var contextUser = new Claim(ClaimTypes.Role, "Zelfhulpgroep_ban");
            
            var mgr = MockUserManager();
            var usr = GetRoleManagerMock();

            contextUser = new Claim(ClaimTypes.Role, "Client");
            
            ModeratorController moderator = new ModeratorController(mgr.Object, usr.Object, context);

            var appUser = CreateApplicationUser();

            var s = moderator.Blokkeren(appUser.Id);

            Assert.NotNull(s);
            Assert.NotEqual("Zelfhulpgroep_ban", contextUser.Value);
            Assert.Equal("Client", contextUser.Value);
            
        }
        
        [Fact]
        public void IndexModeratorTest(){

            DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("ApplicationDbContext").Options;
            ApplicationDbContext c = new ApplicationDbContext(options);
            var mgr = MockUserManager();
            var usr = GetRoleManagerMock();
            
            c.Add(new ApplicationUser{
                Voornaam = "Younes",
                Achternaam = "El Bali",
                GeboorteDatum = DateTime.Parse("01-01-2000"),
                Postcode = "2873HU",
                Huisnummer = "2810KI",
                HulpverlenerEmail = "hulpoverlener@gmail.com"
            });

            c.SaveChanges();

            Assert.Equal(1,c.AppUsers.Count());
        }
    }   
}