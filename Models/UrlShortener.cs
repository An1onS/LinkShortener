using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Models
{
	public static class UrlShortener
	{
		public static string GetShortUrl(string url)
		{
			var hash = url.GetHashCode();
			return hash.ToString();//Convert.ToBase64String(BitConverter.GetBytes(hash));
		}
	}
}
