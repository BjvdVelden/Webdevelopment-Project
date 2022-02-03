using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class IntakeControllerTest
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

        private static Intake createIntake()
        {
            Intake intake = new Intake{
                IntakeId = 1,
                Voornaam = "Serdin",
                Achternaam = "Durmishi",
                GeboorteDatum = DateTime.Parse("01/01/2005"),
                BSN = "BSN-01",
                EmailVoogd = "ouder@test.com",
                Email = "serdin@test.com",
                GewensteHulpverlener = "hulpverlener1@test.com",
                GewensteMoment = DateTime.Now,
                Onderwerp = "Despressie",
                AanmaakDatum = DateTime.Now,
                IsAfgehandeld = false
            };
            return intake;
        }

        [Fact]
        public void IntakeOuderTestAsync(){
            var mgr = MockUserManager();
            var controller = new IntakeController(context, mgr.Object);
            
            var intake = createIntake();

            Task<IActionResult> intakeOuder = controller.CVoogd(intake);
            
            Assert.NotNull(intakeOuder);
            Assert.Equal("Serdin",intake.Voornaam);
            Assert.Equal("Despressie",intake.Onderwerp);
        }


        [Fact]
        public void IndexIntakeTest(){

            DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("ApplicationDbContext").Options;
            ApplicationDbContext c = new ApplicationDbContext(options);
            
            c.Add(createIntake());
            c.SaveChanges();
            Assert.Equal(1,c.Intake.Count());
        }
    }   
}
