using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTrainning.CodeFirst
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext()
            : base()
        {
            
        }
        public DbSet<User> Users { get; set; } 
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Grade> Grades { get; set; }

    }
}
