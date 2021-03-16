using System;
using Microsoft.EntityFrameworkCore;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.DataAccess
{
    public class WaffleContext:DbContext
    {
        public WaffleContext(DbContextOptions<WaffleContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
