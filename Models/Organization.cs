using System.Collections.Generic;

namespace MyOrgApp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JobTypeId { get; set; }
        public JobType jobType { get; set; }
        public ICollection<OrgJobType> OrgJobTypes { get; set; }
    }
}
