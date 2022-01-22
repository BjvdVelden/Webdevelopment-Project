using System;
using System.Collections.Generic;
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
    public class ChatControllerTest
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

        [Fact]
        public void CreateRoomTest(){
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            

            controller.CreateRoom();

            chatMock.Verify(s => s.CreateRoom(It.IsAny<string>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<string>()), Times.Once);



        }
    }   
}