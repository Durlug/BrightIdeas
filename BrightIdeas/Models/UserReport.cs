using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class UserReport
    {
        [Key]
        public int UserReportId { get; set; }
        [Required]
        //[ForeignKey("User")]
        public int UserId { get; set; }

        public string ReportedByName { get; set; }

       // [Required]
       // [ForeignKey("ReportedUser")]
        //public int ReportedUserId { get; set; }
        [Required]
        public string Comments { get; set; }

        public User User { get; set; }
        //public User ReportedUser { get; set; }
    }
}