using System;
using System.ComponentModel.DataAnnotations;
namespace BrightIdeas.Models
{
    public class IdeaFollower
    {
        [Key]
        public int IdeaFollowerId { get; set; }
        [Required]
        public int IdeaId { get; set; }
        [Required]
        public int FollowerUserId { get; set; }

        public User User { get; set; }
    }
}