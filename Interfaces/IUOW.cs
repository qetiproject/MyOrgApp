using System.Threading.Tasks;

namespace MyOrgApp.Interfaces
{
    public interface IUOW
    {
        IJobTypeRepository JobTypeRepository { get; }
        Task<bool> Save();
    }
}
