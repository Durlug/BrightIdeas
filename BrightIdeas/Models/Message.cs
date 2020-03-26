using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string MessageText { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}