using Foundation;
using System;
using UIKit;

namespace xamarintraining.iOS
{
    public partial class SecondViewController : UITableViewController
    {
        public string Parameter { get; set; }

        public SecondViewController(IntPtr handle) : base(handle)
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = TableView.DequeueReusableCell("mycell", indexPath);

            cell.TextLabel.Text = Parameter;
            cell.DetailTextLabel.Text = "this is detailed text";
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 100;
        }
    }
}