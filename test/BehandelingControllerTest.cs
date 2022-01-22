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
    public class BehandelingControllerTest
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

        private BehandelingController createController() {
            context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TemporaryDatabase").Options);
            var userManager = MockUserManager();
            return new BehandelingController(context);
        }

        private static Behandeling createBehandeling()
        {
            Behandeling behandeling = new Behandeling{
                Id = 1,
                Omschrijving = "Heb verteld tot 10 tellen!",
                Datum = DateTime.Now,
                Email = "hulpverlener1@gmail.com"
            };
            return behandeling;
        }

        [Fact]
        public void BehandelingCreateTest() {
            var controller = new BehandelingController(context);
            Behandeling behandeling = createBehandeling();
            var s = controller.Create(behandeling);
            
            Assert.NotNull(s);
            Assert.Equal("Heb verteld tot 10 tellen!", behandeling.Omschrijving);
            Assert.NotEqual(" ", behandeling.Omschrijving);
        }

        [Fact]
        public void TestIndexView()
        {
            var controller = new BehandelingController(context);

            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }


        // Zoek uit
        // [Fact]
        // public void BehandelingTest() {
        //     var controller = new BehandelingController(context);
        //     Behandeling behandeling = createBehandeling();
        //     var s = controller.Create(behandeling);

        //     IActionResult result = controller.Index() as IActionResult;

        //     Assert.Null(result);
        // }
    }   
}