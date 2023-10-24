using System;
using System.ComponentModel.DataAnnotations;

namespace webApi.Models
{
	public class Category
	{
		[Key]
		public int ID { set; get; }

		[Required]
		[StringLength(50)]
		public string? Name { set; get; }

		[Required]
		public bool IsActive { set; get; }

		public virtual List<Product>? Products { set; get; }
	}
}

