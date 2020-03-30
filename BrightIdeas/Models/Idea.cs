using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
	public class Idea
	{
		[Key]
		public int IdeaId { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		[ForeignKey("CreatorUser")]
		public int CreatorUserId { get; set; }
		[Required]
		[ForeignKey("LeaderUser")]
		public int LeaderUserId { get; set; }
		[Required]
		public int MediaId { get; set; }
		[Required]
		public int UpdateId { get; set; }
		[Required]
		public DateTime DateTime { get; set; }
		[Required]
		public User CreatorUser { get; set; }
		public User LeaderUser { get; set; }
		public Media Media { get; set; }
		public Update Update { get; set; }
		public ICollection<ToDo> ToDoList { get; set; }
		[Required]
		public ICollection<Member> IdeaMembers { get; set; }
		[Required]
		public ICollection<IdeaReport> IdeaReports { get; set; }    //for number of reports

	}
}