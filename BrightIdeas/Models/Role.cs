using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}