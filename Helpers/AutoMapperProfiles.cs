﻿using AutoMapper;
using MyOrgApp.DTOs;
using MyOrgApp.Models;

namespace MyOrgApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobType, JobTypeDTO>().ReverseMap();
        }
    }
}