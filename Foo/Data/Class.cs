using Foo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foo.Data
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
        {

        }


        public virtual DbSet<Applicant> Applicants { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }
    }
}
