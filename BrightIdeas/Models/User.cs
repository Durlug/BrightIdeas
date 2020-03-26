using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public int ProfileId { get; set; }
		[Required]
		public bool IsVerified { get; set; }
		[Required]
		public int CredientialsId { get; set; }
		[Required]
		public ICollection<UserReport> UserReports { get; set; }

	}
}