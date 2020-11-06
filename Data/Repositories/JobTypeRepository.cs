using MyOrgApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task<IEnumerable<JobType>> GetJobTypes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }
    }
}
