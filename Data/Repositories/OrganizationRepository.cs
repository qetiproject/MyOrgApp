using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyOrgApp.DTOs;
using MyOrgApp.Interfaces;
using MyOrgApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyOrgApp.Data.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly OrganizationDBContext _odc;
        private readonly IMapper _mapper;

        public OrganizationRepository(OrganizationDBContext odc, IMapper mapper)
        {
            _odc = odc;
            _mapper = mapper;
        }
        public async Task<Result> GetOrganizations()
        {
            List<Organization> dbResult = new List<Organization>();
            Result result = new Result();

            try
            {
                dbResult = await _odc.Organizations.ToListAsync();
                List<OrganizationDTO> organizationDto = _mapper.Map<List<OrganizationDTO>>(dbResult);

                result.Success = true;
                result.Data = organizationDto;
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
