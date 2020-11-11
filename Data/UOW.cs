using MyOrgApp.Data.Repositories;
using MyOrgApp.Interfaces;
using System.Threading.Tasks;

namespace MyOrgApp.Data
{
    public class UOW : IUOW
    {
        private readonly OrganizationDBContext odc;
        public UOW(OrganizationDBContext odc)
        {
            this.odc = odc;
        }
        public IJobTypeRepository JobTypeRepository =>
            new JobTypeRepository(odc);

        public async Task<bool> Save()
        {
            return await odc.SaveChangesAsync() > 0;
        }
    }
}
