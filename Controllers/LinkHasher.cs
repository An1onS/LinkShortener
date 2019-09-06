using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Controllers
{
	public class LinkHasher
	{
		public static string GetShortUrl(string Url)
		{
			//! может быть отрицательным
			return Url.GetHashCode().ToString();
		}
	}
}
