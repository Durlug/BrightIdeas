using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class Crediential
    {
        [Key]
        public int CredientialId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public ICollection<PasswordNames> PreviousPasswords { get; set; }
    }
}