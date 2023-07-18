using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace examMVC.Entities
{
	[Table("Contacts")]
	public class Contact
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(200)]
		public string ContactName { get; set; }

		[Required]
		public string ContactNumber { get; set; }

		[StringLength(200)]
		public string GroupName { get; set; }

		public DateOnly HireDate { get; set; }

		[Required]
		public DateTime Birthday { get; set; }
	}
}

