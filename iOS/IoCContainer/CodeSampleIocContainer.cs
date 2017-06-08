using System;
namespace CodeSample.iOS
{
	public class CodeSampleIocContainer
	{
		NetworkRequestService networkRequestService;

		public CodeSampleIocContainer()
		{
			networkRequestService = new NetworkRequestService();
		}

		public CodeSampleTableViewDataSource GetViewControllerDataSource(SampleMovieListing data)
		{
			var codeSampleTableDataSource = new CodeSampleTableViewDataSource(data);
			return codeSampleTableDataSource;
		}

		public NetworkRequestService GetNetwprkRequestService()
		{
			return networkRequestService;
		}
	}
}
