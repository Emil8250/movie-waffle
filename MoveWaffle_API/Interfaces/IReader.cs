using System;
using System.Linq;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Interfaces
{
    public interface IReader
    {
        Television GetTelevision();
        User GetUser();
        IQueryable<User> GetUsers();
    }
}
