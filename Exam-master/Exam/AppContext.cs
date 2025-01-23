using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam;
using Microsoft.EntityFrameworkCore;
public class AppContext : DbContext
    {
        public class ApplicationContext : DbContext
        {
            public DbSet<User> Users { get; set; } = null!;
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Exam.db");
            }
        }
    }
}
