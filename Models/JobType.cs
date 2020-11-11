using System;

namespace MyOrgApp.Models
{
    public class JobType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
