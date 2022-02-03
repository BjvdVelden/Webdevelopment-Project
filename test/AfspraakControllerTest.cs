using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Webdevelopment_Project.Controllers;
using Webdevelopment_Project.Data;
using Webdevelopment_Project.Models;
using Xunit;

namespace test
{
    public class AfspraakControllerTest
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
        private static Afspraak createAfspraak()
        {
            Afspraak afspraak = new Afspraak{
                AfspraakId = 1,
                ClientEmail = "serdin@outlook.com",
                HulpverlenerEmail = "hulpverlener1@gmail.com",
                Start = DateTime.Now,
                Eind = DateTime.Now,
                Onderwerp = "Depressie",
                GoedkeuringVoogd = true
            };
            return afspraak;
        }

        [Fact]
        public void AfspraakCreateTest() {
            var mgr = MockUserManager();
            var controller = new AfspraakController(context, mgr.Object);
            Afspraak afspraak = createAfspraak();
            var s = controller.Create(afspraak);
            
            Assert.Equal("serdin@outlook.com", afspraak.ClientEmail);
            Assert.True(afspraak.HulpverlenerEmail.Equals("hulpverlener1@gmail.com"));


        }

        [Fact]
        public void AccesCheckAsyncTest() {
            var mgr = MockUserManager();
            var controller = new AfspraakController(context, mgr.Object);
            Afspraak afspraak = createAfspraak();

            var s = controller.AccesCheckAsync(afspraak);
            
            Assert.True(afspraak.ClientEmail.Equals("serdin@outlook.com"));
        }

        // [Fact]
        // public async Task EditAfspraakTestAsync() {
        //     var mgr = MockUserManager();
        //     var controller = new AfspraakController(context, mgr.Object);
        //     Afspraak afspraak = createAfspraak();
            
        //     Assert.True(afspraak.Onderwerp.Equals("Depressie"));

        //     Afspraak afspraak1 = new Afspraak{
        //         AfspraakId = 1,
        //         ClientEmail = "serdin@outlook.com",
        //         HulpverlenerEmail = "hulpverlener1@gmail.com",
        //         Start = DateTime.Now,
        //         Eind = DateTime.Now,
        //         Onderwerp = "Anorexia"
        //     };
        
        //     await controller.Edit(afspraak.AfspraakId, afspraak1);

        //     Afspraak afspraak2 = createAfspraak();
            
        //     Xunit.Assert.True(afspraak2.Onderwerp.Equals("Anorexia"));
        // }
    }   
}
