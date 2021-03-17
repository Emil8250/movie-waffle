using System;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Interfaces
{
    public interface IWriter
    {
        bool CreateUser(User user);
        bool DeleteUser(Guid uuid);
    }
}
