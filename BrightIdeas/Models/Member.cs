using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int IdeaId { get; set; }
        [Required]
        public int MemberLevel { get; set; }

        public User User { get; set; }

        public Role Role { get; set; }
        public Idea Idea { get; set; }
    }
}