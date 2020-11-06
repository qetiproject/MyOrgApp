using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOrgApp.Data;
using MyOrgApp.Models;
using System.Threading.Tasks;

namespace MyOrgApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jobTypeController : ControllerBase
    {
        private OrganizationDBContext odc;
        public jobTypeController(OrganizationDBContext odc)
        {
            this.odc = odc;
        }

        [Route("GetjobTypes")]
        //GET api/jobType
        [HttpGet]
        public async Task<IActionResult> GetjobTypes()
        {
            var jobTypes = await odc.JobTypes.ToListAsync();
            return Ok(jobTypes);
        }

        //POST api/jobType/add?jobTypeName=development2
        //POST api/jobType/add/{jobTypeName}
        [HttpPost("create/{jobTypeName}")]
        public async Task<IActionResult> CreateJobType(string jobTypeName)
        {
            JobType jobType = new JobType();
            jobType.Name = jobTypeName;
            await odc.JobTypes.AddAsync(jobType);
            await odc.SaveChangesAsync();
            return Ok(jobType);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateJobType(JobType jobType)
        {
            await odc.JobTypes.AddAsync(jobType);
            await odc.SaveChangesAsync();
            return Ok(jobType);
        }

        [HttpPost("delete{id}")]
        public async Task<IActionResult> DeleteJobType(int id)
        {
            var jobType = await odc.JobTypes.FindAsync(id);
            odc.JobTypes.Remove(jobType);
            await odc.SaveChangesAsync();
            return Ok(id);
        }
    }
}
