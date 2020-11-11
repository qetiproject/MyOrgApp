using MyOrgApp.Models;
using System.Threading.Tasks;

namespace MyOrgApp.Interfaces
{
    public interface IOrganizationRepository
    {
        Task<Result> GetOrganizations();
    }
}
