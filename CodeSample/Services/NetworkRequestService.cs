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
			//SampleMovieListing sampleObject = null;

			using (WebResponse response = await httpWebRequest.GetResponseAsync())
			{
				using (Stream stream = response.GetResponseStream())
				{
					//stream.Position = 0;
					var serializer = new DataContractJsonSerializer(typeof(SampleMovieListing));
					var sampleMovieListingObject = (SampleMovieListing)serializer.ReadObject(stream);
					//stream.Dispose();
					return sampleMovieListingObject;
				}
			}
		}
		//public void GetData(String uri)
		//{

		//	System.Diagnostics.Debug.WriteLine("Hello");


		//	var obj = GetWebRequestAsync(uri).GetAwaiter();

		//	obj.OnCompleted(() =>
		//	{
		//		var sobj = obj.GetResult();
		//		System.Diagnostics.Debug.WriteLine("OnComplete: " + sobj);
		//		System.Diagnostics.Debug.WriteLine("OnComplete: " + sobj.Title);
		//		System.Diagnostics.Debug.WriteLine("OnComplete: " + sobj.Description);
		//		System.Diagnostics.Debug.WriteLine("OnComplete: " + sobj.Movies[1].Title);
		//		System.Diagnostics.Debug.WriteLine("OnComplete: " + sobj.Movies[1].ReleaseYear);
		//	});

		//	System.Diagnostics.Debug.WriteLine("Description: " + obj);
		//}

		//private async Task<SampleMovieListing> GetWebRequestAsync(String url)
		//{
		//	HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		//	httpWebRequest.ContentType = "application/json";
		//	httpWebRequest.Method = "GET";
		//	//SampleMovieListing sampleObject = null;

		//	using (WebResponse response = await httpWebRequest.GetResponseAsync())
		//	{
		//		using (Stream stream = response.GetResponseStream())
		//		{
		//			//stream.Position = 0;
		//			var serializer = new DataContractJsonSerializer(typeof(SampleMovieListing));
		//			var obj = (SampleMovieListing)serializer.ReadObject(stream);
		//			//stream.Dispose();
		//			return obj;
		//		}
		//	}
		//	//System.Diagnostics.Debug.WriteLine("GetWebRequestAsync Description: " + sampleObject.Title);
		//	//return sampleObject;
		//}
	}
}
