using System;
using System.Runtime.Serialization;

namespace CodeSample
{
	[DataContract]
	public class SampleMovieListing
	{
		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "movies")]
		public Movie[] Movies { get; set; }

	}
}
