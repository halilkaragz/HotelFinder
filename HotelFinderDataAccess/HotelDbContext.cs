using HotelFinderEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinderDataAccess
{
    class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HotelDB;Trusted_Connection=true");
        }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
