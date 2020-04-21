using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace MvvMCross.Core.ViewModels
{
  public class SecondViewModel : MvxViewModel
  {
    private readonly IMvxNavigationService _navigationService;
    private MvxCommand _navigateToFirstViewCommand;
    public IMvxCommand NavigateToFirstViewCommand => _navigateToFirstViewCommand;

    private async Task NavigateToFirstView()
    {
      //We don't use the commented line below because this will create a new instance of the MainViewModel
      // await _navigationService.Navigate<MainViewModel>();
      await _navigationService.Close(this);
    }

    public override void Start()
    {
      _navigateToFirstViewCommand = new MvxCommand(async () => await NavigateToFirstView());
      base.Start();
    }

    public SecondViewModel(IMvxNavigationService navigationService)
    {
      _navigationService = navigationService;
    }
  }
}
