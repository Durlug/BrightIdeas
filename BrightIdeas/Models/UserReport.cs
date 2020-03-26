using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class UserReport
    {
        [Key]
        public int UserReportId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ReportedUserId { get; set; }
        [Required]
        public string Comments { get; set; }
    }
}