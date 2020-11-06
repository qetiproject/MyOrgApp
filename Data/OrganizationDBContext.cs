using Microsoft.EntityFrameworkCore;
using MyOrgApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrgApp.Data
{
    public class OrganizationDBContext : DbContext
    {
        public OrganizationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<JobType> JobTypes { get; set; }

    }
}
