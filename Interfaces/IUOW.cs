using System.Threading.Tasks;

namespace MyOrgApp.Interfaces
{
    public interface IUOW
    {
        IJobTypeRepository JobTypeRepository { get; }
        IOrganizationRepository OrganizationRepository { get; }
        Task<bool> Save();
    }
}
