using System;
using MoveWaffle_API.DataAccess;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Implementation
{
    public class Writer:IWriter
    {
        private readonly WaffleContext _dbContext;
        public Writer(WaffleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateUser(User user)
        {
            _dbContext.Add<User>(user);
            return _dbContext.SaveChanges() > 0 ? true : false;
        }

        public bool DeleteUser(Guid uuid)
        {
            // User user = new User() { ID = uuid };
            var user = _dbContext.Find<User>(uuid);
            _dbContext.Users.Attach(user);
            _dbContext.Remove<User>(user);
            return _dbContext.SaveChanges() > 0 ? true : false;
        }
    }
}
