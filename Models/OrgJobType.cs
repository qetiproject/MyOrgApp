namespace MyOrgApp.Models
{
    public class OrgJobType
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
