﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyOrgApp.DTOs;
using MyOrgApp.Interfaces;
using MyOrgApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrgApp.Data.Repositories
{
    public class JobTypeRepository : IJobTypeRepository
    {
        private readonly OrganizationDBContext _odc;
        private readonly IMapper _mapper;

        public JobTypeRepository(OrganizationDBContext odc, IMapper mapper)
        {
            _odc = odc;
            _mapper = mapper;
        }

        public void CreatejobType(JobType jobType)
        {
           _odc.JobTypes.AddAsync(jobType);
        }

        public void DeletejobType(int jobTypeId)
        {
            var jobType = _odc.JobTypes.Find(jobTypeId);
            _odc.JobTypes.Remove(jobType);
        }

        public async Task<Result> GetJobTypes()
        {
            List<JobType> dbResult = new List<JobType>();
            Result result = new Result();

            try
            {
                dbResult = await _odc.JobTypes.ToListAsync();
                List<JobTypeDTO> jobTypesDto = _mapper.Map<List<JobTypeDTO>>(dbResult);
                
                result.Success = true;
                result.Data = jobTypesDto;
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
