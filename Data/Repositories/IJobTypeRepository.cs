using MyOrgApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrgApp.Data.Repositories
{
    public interface IJobTypeRepository
    {
        Task<IEnumerable<JobType>> GetJobTypes();
        void CreatejobType(JobType jobType);
        void DeletejobType(int jobTypeId);
        Task<bool> Save();

    }
}
