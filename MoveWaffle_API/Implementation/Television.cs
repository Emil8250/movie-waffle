using System;
using MoveWaffle_API.Interfaces;

namespace MoveWaffle_API.Implementation
{
    public class Television:IReader
    {
        public Models.Television GetTelevision()
        {
            return new Models.Television
            {
                Name = "",
                YearEnd = 2018,
                YearStart = 2004

            };
        }
    }
}
