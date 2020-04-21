using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MvvMCross.Core.ViewModels;

namespace MvvMCross.WPF.Views
{
  /// <summary>
  /// Interaction logic for SecondView.xaml
  /// </summary>

  [MvxViewFor(typeof(SecondViewModel))]
  public partial class SecondView : MvxWpfView
  {
    public SecondView()
    {
      InitializeComponent();
    }
  }
}
