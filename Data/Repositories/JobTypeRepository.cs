using Microsoft.EntityFrameworkCore;
using MyOrgApp.Interfaces;
using MyOrgApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrgApp.Data.Repositories
{
    public class JobTypeRepository : IJobTypeRepository
    {
        private readonly OrganizationDBContext odc;
        public JobTypeRepository(OrganizationDBContext odc)
        {
            this.odc = odc;
        }
        public void CreatejobType(JobType jobType)
        {
            odc.JobTypes.AddAsync(jobType);
        }

        public void DeletejobType(int jobTypeId)
        {
            var jobType = odc.JobTypes.Find(jobTypeId);
            odc.JobTypes.Remove(jobType);
        }

        public async Task<IEnumerable<JobType>> GetJobTypes()
        {
            return await odc.JobTypes.ToListAsync();
        }
    }
}
