using Microsoft.EntityFrameworkCore;
using MultibleDbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultibleDbCRUD.Contexts
{
    public class SchoolTwoContext :DbContext
    {
        public SchoolTwoContext()
        {

        }

        public SchoolTwoContext(DbContextOptions<SchoolTwoContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
