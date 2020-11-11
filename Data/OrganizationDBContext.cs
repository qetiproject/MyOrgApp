using Microsoft.EntityFrameworkCore;
using MyOrgApp.Models;

namespace MyOrgApp.Data
{
    public class OrganizationDBContext : DbContext
    {
        public OrganizationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrgJobType> OrgJobType { get; set; }

    }
}
