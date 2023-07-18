using System.ComponentModel.DataAnnotations;
namespace examMVC.Models
{
	public class ContactViewModel
	{	
		[Required]
		[MinLength(6,ErrorMessage ="Vui long nhap toi thieu 6 ky tu")]
		[MaxLength(200)]
		[Display(Name ="Ten thue bao")]
		public string ContactName { get; set; }

		[Required]
		[MinLength(10,ErrorMessage ="Nhap du 10 so")]
		[MaxLength(10,ErrorMessage ="Nhap du 10 so")]
		[Display(Name ="So dien thoai")]
		public string ContactNumber { get; set; }

		[Display(Name ="Ten group")]
		public string GroupName { get; set; }

		[Display(Name ="Ngay thue")]
		public DateOnly HireDate { get; set; }

		[Required]
		[Display(Name ="Sinh nhat")]
		public DateTime Birthday { get; set; }

	}
}

