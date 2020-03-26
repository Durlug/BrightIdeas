using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }
        [Required]
        public int MessageId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}