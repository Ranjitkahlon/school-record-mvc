using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolRecord.Models;

namespace SchoolRecord.Data
{
    public class SchoolRecordContext : DbContext
    {
        public SchoolRecordContext (DbContextOptions<SchoolRecordContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolRecord.Models.Staff> Staff { get; set; }

        public DbSet<SchoolRecord.Models.Student> Student { get; set; }

        public DbSet<SchoolRecord.Models.Payment> Payment { get; set; }
    }
}
