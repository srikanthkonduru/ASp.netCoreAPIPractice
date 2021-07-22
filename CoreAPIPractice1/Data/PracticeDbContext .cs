using CoreAPIPractice1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreAPIPractice1.Data
{
    public class PracticeDbContext : DbContext
    {
        //#sri
        public PracticeDbContext(DbContextOptions<PracticeDbContext> options) : base(options)
        { }


        public DbSet<Student> Students { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
