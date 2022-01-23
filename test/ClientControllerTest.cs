using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
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
    public class ClientControllerTest
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
        
        [Fact]
        public void ChatFrequentieTest(){
                
            var mgr = MockUserManager();
            var usr = GetRoleManagerMock();

            var controller = new ClientController(context, usr.Object, mgr.Object);
            
           var s = controller.ChatFrequentie();

         
            
            Assert.NotNull(s);
        }
    }
}