using System;
using System.Linq;
using System.Collections.Generic;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Interfaces
{
    public interface IReader
    {
        Television GetTelevision();
        User GetUser(Guid uuid);
        IQueryable<User> GetUsers();
        List<IMDBTitle> GetTitles();
    }
}
