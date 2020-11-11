using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        //GET api/jobType
        [HttpGet]
        public async Task<Result> GetOrganizations()
        {
            Result organizations = await uow.OrganizationRepository.GetOrganizations();

            return organizations;
        }
    }
}
