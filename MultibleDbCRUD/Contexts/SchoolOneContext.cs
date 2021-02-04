using Microsoft.EntityFrameworkCore;
using MultibleDbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Contexts
{
    public class SchoolOneContext : DbContext
    {
        public SchoolOneContext()
        {

        }

        public SchoolOneContext(DbContextOptions<SchoolOneContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
