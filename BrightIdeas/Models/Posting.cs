using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Posting
    {
        [Key]
        public int PostingId { get; set; }
        [Required]
        public string PostingName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int NumberAvailable { get; set; }
        [Required]
        public int NumberFilled { get; set; }
    }
}