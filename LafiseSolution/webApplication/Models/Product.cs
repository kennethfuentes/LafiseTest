using System;
using System.ComponentModel.DataAnnotations;

namespace webApi.Models
{
	public class Product
	{
		[Key]
		public int ID { set; get; }

		[Required]
		[StringLength(80)]
		public required string Name { set; get; }

        [StringLength(200)]
        public string? Description { set; get; }

		[Required]
		public bool IsActive { set; get; }

		public int CategoryID { set; get; }
		public virtual Category? Category { set; get; }
	}
}

