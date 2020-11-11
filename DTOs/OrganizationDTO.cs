using MyOrgApp.Models;
using System.Collections.Generic;

namespace MyOrgApp.DTOs
{
    public class OrganizationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JobTypeId { get; set; }
    }
}
