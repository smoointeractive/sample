using System;
using Foundation;
using UIKit;
namespace CodeSample
{
	public class CodeSampleTableViewDataSource : UITableViewSource
	{
		SampleMovieListing sampleMovieListing;
		string cellIdentifier = "sampledatacell";
		string titleCellIdentifier = "sampleMovieTitle";
		string descriptioCellIdentifier = "sampleMovieDescription";

		public CodeSampleTableViewDataSource(SampleMovieListing data)
		{
			//networkRequestService = (NetworkRequestService)service;
			sampleMovieListing = data;
			// get data
			System.Diagnostics.Debug.WriteLine("tick");
			System.Diagnostics.Debug.WriteLine(sampleMovieListing.Title);
		}

		public override UITableViewCell GetCell(UITableView tableView, 
		                                        NSIndexPath indexPath)
		{
			System.Diagnostics.Debug.WriteLine("spaced");
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			string item = sampleMovieListing.Movies[indexPath.Row].Title;
			cell.TextLabel.Text = item;


			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, 
				                           cellIdentifier);
			}



			return cell;
		}

		public override nint RowsInSection(UITableView tableview, 
		                                   nint section)
		{
			System.Diagnostics.Debug.WriteLine("Helooesansnak "+sampleMovieListing.Movies.Length);
			return sampleMovieListing.Movies.Length;
		}
	}
}
