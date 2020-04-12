using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Media
    {
        [Key]
        public int MediaId { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        public string MediaFormat { get; set; }
        [Required]
        public string MediaURI { get; set; }

    }
}