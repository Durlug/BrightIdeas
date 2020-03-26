using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        [Required]
        public string ToDoDescription { get; set; }
    }
}