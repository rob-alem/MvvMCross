using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvMCross.Core.ViewModels
{
  public class PopupViewModel : MvxViewModel
  {
    private readonly IMvxNavigationService _navigationService;
    private MvxCommand _closePopupCommand;

    public IMvxCommand ClosePopupCommand => _closePopupCommand;

    private async Task ClosePopup() => await _navigationService.Close(this);

    public PopupViewModel(IMvxNavigationService navigationService)
    {
      _navigationService = navigationService;
      _closePopupCommand = new MvxCommand(async () => await ClosePopup());
    }
  }
}
