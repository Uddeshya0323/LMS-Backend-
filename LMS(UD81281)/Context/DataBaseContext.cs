using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS_UD81281_.Models;



namespace LMS_UD81281_.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {



        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LMS_UD81281_.Models.Login> Login { get; set; }
    }
}