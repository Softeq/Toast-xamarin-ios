﻿// Developed by Softeq Development Corporation
// http://www.softeq.com

using System;
using UIKit;

namespace ToastSamples
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}