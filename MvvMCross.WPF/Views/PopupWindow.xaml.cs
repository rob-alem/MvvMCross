using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MvvMCross.Core.ViewModels;

namespace MvvMCross.WPF.Views
{
  /// <summary>
  /// Interaction logic for PopupWindow.xaml
  /// </summary>

  [MvxViewFor(typeof(PopupViewModel))]
  public partial class PopupWindow : MvxWindow
  {
    public PopupWindow()
    {
      InitializeComponent();
    }
  }
}
