using MyOrgApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrgApp.Interfaces
{
    public interface IJobTypeRepository
    {
        Task<IEnumerable<JobType>> GetJobTypes();
        void CreatejobType(JobType jobType);
        void DeletejobType(int jobTypeId);

    }
}
