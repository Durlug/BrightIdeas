using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Update
    {
        [Key]
        public int UpdateId { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Description { get; set; }

    }
}