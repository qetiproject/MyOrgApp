using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyOrgApp.DTOs;
using MyOrgApp.Interfaces;
using MyOrgApp.Models;
using System.Threading.Tasks;

namespace MyOrgApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IUOW uow;
        private readonly IMapper mapper;
        public OrganizationController(IUOW uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [Route("GetOrganizations")]
        [HttpGet]
        public async Task<Result> GetOrganizations()
        {
            Result organizations = await uow.OrganizationRepository.GetOrganizations();

            return organizations;
        }


        [HttpPost("CreateOrganization")]
        public async Task<IActionResult> CreateOrganization(OrganizationCreateDTO org)
        {
            Organization organization = new Organization
            {
                Name = org.Name,
                JobTypeId = org.JobTypeId
            };
            uow.OrganizationRepository.CreateOrganization(organization);
            await uow.Save();
            return StatusCode(200);
        }

        [HttpDelete("DeleteOrganization/{id}")]
        public async Task<IActionResult> DeleteOrganization(int id)
        {
            uow.OrganizationRepository.DeleteOrganization(id);
            await uow.Save();
            return Ok(id);
        }
    }
}
