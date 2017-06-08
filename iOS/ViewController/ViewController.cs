using System;

using UIKit;

namespace CodeSample.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;


		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				var title = string.Format("{0} clicks!", count++);
				Button.SetTitle(title, UIControlState.Normal);
			};

			var appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
			//SampleDataTableView.Source = appDelegate.iocContainer.GetViewControllerDataSource("https://facebook.github.io/react-native/movies.json");

			var awaiter = appDelegate.iocContainer.GetNetwprkRequestService().
			                         GetData("https://facebook.github.io/react-native/movies.json").
			                         GetAwaiter();

			awaiter.OnCompleted(() => {
				var result = awaiter.GetResult();
				var dataSource = appDelegate.iocContainer.GetViewControllerDataSource(result);
				SampleDataTableView.Source = dataSource;
				SampleDataTableView.ReloadData();
			});

			//networkService = new NetworkRequestService();
			//var data = networkService.GetData("https://facebook.github.io/react-native/movies.json").GetAwaiter();
			//data.OnCompleted(() => {
			//	var result = data.GetResult();
			//	System.Diagnostics.Debug.WriteLine("title: " + result.Description);
			//});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
