using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class PasswordNames
    {
        [Key]
        public int PasswordNamesId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CredientialId { get; set; }

        public Crediential Crediential { get; set; }

    }
}
