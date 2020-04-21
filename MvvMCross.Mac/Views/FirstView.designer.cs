// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCross.Mac
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		AppKit.NSButton addButton { get; set; }

		[Outlet]
		AppKit.NSTextField label { get; set; }

		[Outlet]
		AppKit.NSButton NavigateToSecondViewButton { get; set; }

		[Outlet]
		AppKit.NSButton StartTimerAndShowPopupButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addButton != null) {
				addButton.Dispose ();
				addButton = null;
			}

			if (NavigateToSecondViewButton != null) {
				NavigateToSecondViewButton.Dispose ();
				NavigateToSecondViewButton = null;
			}

			if (StartTimerAndShowPopupButton != null) {
				StartTimerAndShowPopupButton.Dispose ();
				StartTimerAndShowPopupButton = null;
			}

			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
