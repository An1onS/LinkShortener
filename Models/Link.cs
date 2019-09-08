using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Models
{
	public class Link
	{
		//public uint Id { set; get; }
		public string Url { set; get; }
		[Key]
		public string ShortUrl { set; get; }
		[DataType(DataType.Date)]
		public DateTime CreationDate { set; get; }
		public uint Counter { set; get; }
	}
}
