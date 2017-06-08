using System;
using Foundation;
using UIKit;
namespace CodeSample
{
	public class CodeSampleTableViewDataSource : UITableViewSource
	{
		SampleMovieListing sampleMovieListing;
		string cellIdentifier = "sampledatacell";

		public CodeSampleTableViewDataSource(SampleMovieListing data)
		{
			sampleMovieListing = data;
		}

		public override UITableViewCell GetCell(UITableView tableView, 
		                                        NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			string item = String.Format("{0} ({1})", 
			                            sampleMovieListing.Movies[indexPath.Row].Title,
			                            sampleMovieListing.Movies[indexPath.Row].ReleaseYear);
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
			return sampleMovieListing.Movies.Length;
		}

		public override string TitleForHeader(UITableView tableView, nint section)
		{
			return String.Format("{0} \n {1}", 
			                     sampleMovieListing.Title,
			                     sampleMovieListing.Description);
		}
	}
}
