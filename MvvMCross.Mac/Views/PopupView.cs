// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using MvvMCross.Core.ViewModels;
using MvvmCross.Platforms.Mac.Views;
using MvvmCross.Binding.BindingContext;

namespace MvvmCross.Mac
{
	[MvxFromStoryboard("Main")]
	public partial class PopupView : MvxViewController<PopupViewModel>
	{
		public PopupView (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<PopupView, PopupViewModel>();
            set.Bind(CloseButton).To(vm => vm.ClosePopupCommand);
            set.Apply();
        }
    }
}