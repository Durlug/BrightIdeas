using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class IdeaReport
    {
        [Key]
        public int IdeaReportId { get; set; }
        [Required]
        public int IdeaMemberId { get; set; }
        [Required]
        public int LeaderMemberId { get; set; }
    }
}