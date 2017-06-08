using System;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;


namespace CodeSample
{
	public class NetworkRequestService : NetworkRequestServiceInterface
	{
		public NetworkRequestService()
		{
		}

		public async Task<SampleMovieListing> GetData(string uri)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";

			using (WebResponse response = await httpWebRequest.GetResponseAsync())
			{
				using (Stream stream = response.GetResponseStream())
				{
					var serializer = new DataContractJsonSerializer(typeof(SampleMovieListing));
					var sampleMovieListingObject = (SampleMovieListing)serializer.ReadObject(stream);
					return sampleMovieListingObject;
				}
			}
		}
	}
}
