using System;
using Microsoft.EntityFrameworkCore;
using MoveWaffle_API.DataAccess;
using MoveWaffle_API.Implementation;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;
using Xunit;

namespace MoiveWaffle_API_Test
{
    public class DAL
    {
        [Fact]
        public void Test_UserCreationAndDeletion()
        {
            var options = new DbContextOptionsBuilder<WaffleContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .EnableSensitiveDataLogging()
                 .Options;
            var context = new WaffleContext(options);

            var reader = new Reader(context);
            var writer = new Writer(context);

            Guid uuid = Guid.NewGuid();
            var user = new User()
            {
                ID = uuid,
                JoinDate = DateTime.Now,
                UserName = "Test"
            };

            writer.CreateUser(user);
            var retrievedUser = reader.GetUser(uuid);
            Assert.Equal(retrievedUser, user);
            var allUsers = reader.GetUsers();
            Assert.Contains(retrievedUser, allUsers);
            var deleted = writer.DeleteUser(uuid);
            Assert.True(deleted);
            var deletedUser = reader.GetUser(uuid);
            Assert.Null(deletedUser);
        }
    }
}
