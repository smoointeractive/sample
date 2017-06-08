using System;
namespace CodeSample.iOS
{
	public class CodeSampleIocContainer
	{
		NetworkRequestService networkRequestService;
		//CodeSampleTableViewDataSource codeSampleTableDataSource;

		public CodeSampleIocContainer()
		{
			networkRequestService = new NetworkRequestService();
			//codeSampleTableDataSource = new CodeSampleTableViewDataSource(networkRequestService);
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
