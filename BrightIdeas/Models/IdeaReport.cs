using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class IdeaReport
    {
        [Key]
        public int IdeaReportId { get; set; }
        [Required]
        [ForeignKey("IdeaMember")]
        public int IdeaMemberId { get; set; }
        [Required]
        [ForeignKey("LeaderMember")]
        public int LeaderMemberId { get; set; }

        public Member IdeaMember { get; set; }

        public Member LeaderMember { get; set; }
    }
}