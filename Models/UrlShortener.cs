using System;

namespace LinkShortener.Models
{
	public static class UrlShortener
	{
		public static string GetShortUrl(string url)
		{
			var hash = url.GetHashCode();
			return Convert.ToBase64String(BitConverter.GetBytes(hash));
		}
	}
}
