using System;
using System.Runtime.Serialization;
namespace CodeSample
{
	[DataContract]
	public class Movie
	{
		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "releaseYear")]
		public string ReleaseYear { get; set; }
	}
}
