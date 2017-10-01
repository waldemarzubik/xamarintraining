using System;
using UIKit;

namespace xamarintraining.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        partial void ButttonClick(UIButton sender)
        {
            if (string.IsNullOrEmpty(SearchCriteriaTextField.Text))
            {
                return;
            }

            SearchCriteriaTextField.ResignFirstResponder();

            var listViewController = (SecondViewController)this.Storyboard.InstantiateViewController(nameof(SecondViewController));
            listViewController.Parameter = SearchCriteriaTextField.Text;
            this.PresentViewController(listViewController, true, null);
        }
    }
}
