using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task4.Models
{
    public class ProfileContext:DbContext
    {
        public ProfileContext() : base()
        {

        }
        public ProfileContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Profile> profiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { Id = 1, Name = "dhesh", Age = 20, Qualification = "B.E CSE", ISEmployed = true, NoticePeriod = 60, CurrentCTC = 300000 });
        }
    }
}
