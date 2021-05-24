using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace типоSteam.dbl
{
    public class SteamContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public SteamContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ParodyToSteam;Trusted_Connection=True;");
        }

    }
}
