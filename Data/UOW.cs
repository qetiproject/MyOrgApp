using AutoMapper;
using MyOrgApp.Data.Repositories;
using MyOrgApp.Interfaces;
using System.Threading.Tasks;

namespace MyOrgApp.Data
{
    public class UOW : IUOW
    {
        private readonly OrganizationDBContext odc;
        private readonly IMapper _mapper;
        public UOW(OrganizationDBContext odc, IMapper mapper)
        {
            this.odc = odc;
            _mapper = mapper;
        }
        public IJobTypeRepository JobTypeRepository => new JobTypeRepository(odc, _mapper);

        public IOrganizationRepository OrganizationRepository => new OrganizationRepository(odc, _mapper);

        public async Task<bool> Save()
        {
            return await odc.SaveChangesAsync() > 0;
        }
    }
}
