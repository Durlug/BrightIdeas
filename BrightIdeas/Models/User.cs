using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		[Required]
		public string Email { get; set; }
		//[Required]
		//public int UserReportId { get; set; }
		[Required]
		public int UserProfileId { get; set; }
		[Required]
		public bool IsVerified { get; set; }
		[Required]
		public int CredientialId { get; set; }
		//[Required]
		//[InverseProperty("UserReportId")]
		public ICollection<UserReport> UserReports { get; set; }
		public Crediential Crediential { get; set; }
		public UserProfile UserProfile { get; set; }

	}
}