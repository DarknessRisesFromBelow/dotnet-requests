using System.Net;
using System;
using System.IO;
using System.Net.Http;
using YMA.WebInterfacing.WebTypes;

namespace YMA.WebInterfacing
{
	class requests
	{
		public static IWebType HttpGet(string URI, string userAgent = "Mozilla/4.0 YMADotnetClient 1.4", Tuple<HttpRequestHeader, string?>[] headers = null)
		{
			WebClient client = new WebClient();

			client.Headers.Add("user-agent", userAgent);
			if(headers != null)
			{
				foreach(Tuple<HttpRequestHeader, string?> item in headers)
				{
					client.Headers.Add(item.Item1, item.Item2);
				}
			}

			Stream data = client.OpenRead(URI);
			StreamReader reader = new StreamReader(data);
			string s = reader.ReadToEnd();
			data.Close();
			reader.Close();

			return s;
		}

		public static IWebType HttpPost(string url, Dictionary<string, string> postParams)
		{
			var content = new FormUrlEncodedContent(postParams);
  			var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);
  			string responseString = await response.Content.ReadAsStringAsync();
			return responseString;
		}

		public static IWebType HttpsGet(string url)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			

			Stream resStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(resStream);	
			string s = reader.ReadToEnd();

			data.Close();
			reader.Close();
			
			return s;
		}
	}
}