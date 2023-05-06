using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dormitory
{
    internal class MyDbcontext:DbContext
    {
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Dormitories> Dormitories { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<RoomStudents> RoomStudents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=U5LI6EQ; Initial Catalog=Dorm;Integrated Security=True");
        }

    }
}
