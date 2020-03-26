using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class UserProfile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public string Picture { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public string ProfileDescription { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
    }
}