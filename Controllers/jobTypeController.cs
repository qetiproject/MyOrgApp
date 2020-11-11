using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyOrgApp.DTOs;
using MyOrgApp.Interfaces;
using MyOrgApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrgApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jobTypeController : ControllerBase
    {
        private readonly IUOW uow;
        private readonly IMapper mapper;
        public jobTypeController(IUOW uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [Route("GetjobTypes")]
        //GET api/jobType
        [HttpGet]
        public async Task<IActionResult> GetjobTypes()
        {
            var jobTypes = await uow.JobTypeRepository.GetJobTypes();
            var jobTypesDto = mapper.Map<IEnumerable<JobTypeDTO>>(jobTypes);
            //var jobTypesDto = from j in jobTypes select new JobTypeDTO()
            //{
            //    Id = j.Id,
            //    Name = j.Name
            //};
            return Ok(jobTypesDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobType(JobTypeDTO jobTypeDto)
        {
            var jobType = mapper.Map<JobType>(jobTypeDto);
            jobType.LastUpdatedBy = 1;
            jobType.LastUpdatedOn = DateTime.Now;
            //var jobType = new JobType
            //{
            //    Name = jobTypeDto.Name,
            //    LastUpdatedBy = 1,
            //    LastUpdatedOn = DateTime.Now
            //};

            uow.JobTypeRepository.CreatejobType(jobType);
            await uow.Save();
            return StatusCode(200);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteJobType(int id)
        {
            uow.JobTypeRepository.DeletejobType(id);
            await uow.Save();
            return Ok(id);
        }
    }
}
