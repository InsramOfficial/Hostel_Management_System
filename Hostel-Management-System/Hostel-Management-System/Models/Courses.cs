using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel_Management_System.Models
{
	[Table("courses")]
	public class Courses
	{
		[Key]
		public int Id { get; set; }
		public string course_code { get; set; }
		public string course_Name { get; set; }
		public DateTime posting_date { get; set; }
	}
}
