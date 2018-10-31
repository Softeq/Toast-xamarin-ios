// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using UIKit;
using Foundation;
using ToastBindings;
using CoreGraphics;

namespace ToastSamples
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            BasicUsageBtn.TouchUpInside += (sender, e) => MakeBasic();
            MakeWithDurationBtn.TouchUpInside += (sender, e) => MakeWithDurationAndPosition();
        }

        private void MakeBasic()
        {
            View.MakeToast(new NSString("This is a piece of toast"));
        }

        private void MakeWithDurationAndPosition()
        {
            View.MakeToast(new NSString("This is a piece of toast on top for 3 seconds"),
                           3.0f,
                           CSToastPosition.Center);
        }

        private void MakeWithTitle()
        {
            View.MakeToast(new NSString("This is a piece of toast with a title"),
                           2.0f,
                           CSToastPosition.Top,
                           new NSString("Toast Title"),
                           new UIImage(),
                           new CSToastStyle(),
                           x => { });
        }

        private void ShowCustomToast()
        {
            var customView = new UIView(new CGRect(0, 0, 80, 400));
            customView.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin |
                                          UIViewAutoresizing.FlexibleRightMargin |
                                          UIViewAutoresizing.FlexibleTopMargin |
                                          UIViewAutoresizing.FlexibleBottomMargin;
            customView.BackgroundColor = UIColor.Orange;

            View.ShowToast(customView, 2f, CSToastPosition.Center, x => { });
        }
    }
}
