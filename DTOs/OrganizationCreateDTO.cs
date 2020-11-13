using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyOrgApp.DTOs
{
    public class OrganizationCreateDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int JobTypeId { get; set; }
    }
}
