using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MoveWaffle_API.DataAccess;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Implementation
{
    public class Reader:IReader
    {
        private readonly WaffleContext _dbContext;
        public Reader(WaffleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.Television GetTelevision()
        {
            return new Models.Television
            {
                Name = "",
                YearEnd = 2018,
                YearStart = 2004

            };
        }

        public User GetUser()
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetUsers()
        {
            //throw new NotImplementedException();
            return _dbContext.Set<User>();
        }
    }
}
