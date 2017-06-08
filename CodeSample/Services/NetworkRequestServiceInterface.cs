using System;
using System.Threading.Tasks;
namespace CodeSample
{
	public interface NetworkRequestServiceInterface
	{
		Task<SampleMovieListing> GetData(String uri);
	}
}
