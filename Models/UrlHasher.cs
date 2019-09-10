using System;

namespace LinkShortener.Models
{
	public static class UrlHasher
	{
		public static string GetHashedUrl(string url)
		{
			var hash = url.GetHashCode();
			return Convert.ToBase64String(BitConverter.GetBytes(hash));
		}
	}
}
