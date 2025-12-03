using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Classes
{
    public class DbContexted : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<BlackList> BlackLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "server=127.0.0.1;port=3306;database=license;user=root;password=",
                new MySqlServerVersion(new Version(8, 0)));
        }
    }
}
