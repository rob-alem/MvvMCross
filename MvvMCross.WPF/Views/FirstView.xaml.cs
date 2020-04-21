using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MvvMCross.Core.ViewModels;

namespace MvvMCross.WPF.Views
{
  /// <summary>
  /// Interaction logic for FirstView.xaml
  /// </summary>

  [MvxViewFor(typeof(MainViewModel))]
  public partial class FirstView : MvxWpfView
  {
    public FirstView()
    {
      InitializeComponent();
    }
  }
}
