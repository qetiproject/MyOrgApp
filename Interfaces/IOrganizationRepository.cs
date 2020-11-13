using MyOrgApp.Models;
using System.Threading.Tasks;

namespace MyOrgApp.Interfaces
{
    public interface IOrganizationRepository
    {
        Task<Result> GetOrganizations();
        void CreateOrganization(Organization organization);
        void DeleteOrganization(int orgId);
    }
}
