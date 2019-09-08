using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkShortener.Models
{
	public static class UrlShortener
	{
		static string GetShortUrl(string url)
		{
			var hash = url.GetHashCode();
			return Convert.ToBase64String(BitConverter.GetBytes(hash));
		}
	}
}
