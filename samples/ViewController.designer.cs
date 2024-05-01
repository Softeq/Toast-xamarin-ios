// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ToastSamples
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton BasicUsageBtn { get; set; }

		[Outlet]
		UIKit.UIButton ClearQueueBtn { get; set; }

		[Outlet]
		UIKit.UIButton HideToastsAndClearQueueBtn { get; set; }

		[Outlet]
		UIKit.UIButton HideToastsBtn { get; set; }

		[Outlet]
		UIKit.UIButton MakeWithDurationBtn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BasicUsageBtn != null) {
				BasicUsageBtn.Dispose ();
				BasicUsageBtn = null;
			}

			if (ClearQueueBtn != null) {
				ClearQueueBtn.Dispose ();
				ClearQueueBtn = null;
			}

			if (HideToastsBtn != null) {
				HideToastsBtn.Dispose ();
				HideToastsBtn = null;
			}

			if (HideToastsAndClearQueueBtn != null) {
				HideToastsAndClearQueueBtn.Dispose ();
				HideToastsAndClearQueueBtn = null;
			}

			if (MakeWithDurationBtn != null) {
				MakeWithDurationBtn.Dispose ();
				MakeWithDurationBtn = null;
			}
		}
	}
}
