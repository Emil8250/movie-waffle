using System;
using System.Collections.Generic;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Interfaces
{
    public interface IReader
    {
        Television GetTelevision();
        public List<IMDBTitle> GetTitles();
    }
}
