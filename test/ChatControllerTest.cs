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
        public void CreatePrivateRoomTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            
            chatMock.Object.CreatePrivateRoom("RootId", "TargetId");

            chatMock.Verify(s => s.CreatePrivateRoom(It.IsAny<string>(),It.IsAny<string>()), Times.Once);
            chatMock.Verify(s => s.CreatePrivateRoom(It.Is<string>(s => s == "RootId"),It.Is<string>(s => s == "TargetId")), Times.Once);
        }

        [Fact]
        public void AccessChatTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
        }

        [Fact]
        public void JoinRoomTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            
            chatMock.Object.JoinRoom(1, "userId");

            chatMock.Verify(s => s.JoinRoom(It.IsAny<int>(),It.IsAny<string>()), Times.Once);
            chatMock.Verify(s => s.JoinRoom(It.Is<int>(s => s == 1),It.Is<string>(s => s == "userId")), Times.Once);
        }

        [Fact]
        public void CreateMessageTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            
            chatMock.Object.CreateMessage(1, "Hallo Bob", "userId");

            chatMock.Verify(s => s.CreateMessage(It.IsAny<int>(),It.IsAny<string>(),It.IsAny<string>()), Times.Once);
            chatMock.Verify(s => s.CreateMessage(It.Is<int>(s => s == 1),It.Is<string>(s => s == "Hallo Bob"),It.Is<string>(s => s == "userId")), Times.Once);
        }

        [Fact]
        public void CreateRoomTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            
            chatMock.Object.CreateRoom("name", 4, 7, "userId");

            chatMock.Verify(s => s.CreateRoom(It.IsAny<string>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<string>()), Times.Once);
            chatMock.Verify(s => s.CreateRoom(It.Is<string>(s => s == "name"),It.Is<int>(s => s == 4),It.Is<int>(s => s == 7),It.Is<string>(s => s == "userId")), Times.Once);
        }

        [Fact]
        public void FindGroupTest(){
            var mgr = MockUserManager();
            Mock<IChatRepository> chatMock = new Mock<IChatRepository>();
            var controller = new ChatController(chatMock.Object, context);
            
            chatMock.Object.FindGroup("Depressie", 18);

            chatMock.Verify(s => s.FindGroup(It.IsAny<string>(),It.IsAny<int>()), Times.Once);
            chatMock.Verify(s => s.FindGroup(It.Is<string>(s => s == "Depressie"),It.Is<int>(s => s == 18)), Times.Once);
        }

        private static Report createReport()
        {
            Report report = new Report{
                ReportId = 1,
                Reden = "League of legends toxic"
            };
            return report;
        }

        [Fact]
        public void AbuseReportTest(){

            ReportController report = new ReportController(context);
            
            var createreport = createReport();

            var s = report.Create(createreport);
            Assert.NotNull(s);
            Assert.Equal("League of legends toxic", createreport.Reden);
        }
    }   
}