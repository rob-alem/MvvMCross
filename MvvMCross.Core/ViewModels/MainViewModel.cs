using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;
using System.Timers;

namespace MvvMCross.Core.ViewModels
{
  public class MainViewModel : MvxViewModel
  {
    private readonly IMvxNavigationService _navigationService;
    private string _text = "Hello";
    private bool _timerButtonEnabled = true;
    private MvxCommand _navigateToSecondViewCommand;
    private MvxCommand _resetTextCommand;
    private MvxCommand _startTimerCommand;

    private Timer _timer;
    private TaskScheduler _scheduler;

    public IMvxCommand ResetTextCommand => _resetTextCommand;
    public IMvxCommand NavigateToSecondViewCommand => _navigateToSecondViewCommand;
    public IMvxCommand StartTimerCommand => _startTimerCommand;

    public string Text
    {
      get => _text;
      set
      {
        SetProperty(ref _text, value);
      }
    }

    public bool TimerButtonEnabled { get => _timerButtonEnabled; private set { SetProperty(ref _timerButtonEnabled, value); } }

    private void ResetText()
    {
      Text = "Hello MvvmCross";
    }

    private void StartTimer()
    {
      TimerButtonEnabled = false;

      _scheduler = TaskScheduler.FromCurrentSynchronizationContext();

      _timer = new Timer(5000);
      _timer.Start();
      _timer.Elapsed += TimerElapsed;
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
      new Task(TimerElapsedOnMainThread).Start(_scheduler);
    }

    private void TimerElapsedOnMainThread()
    {
      _timer.Stop();
      TimerButtonEnabled = true;
      _navigationService.Navigate<PopupViewModel>();
    }

    private async Task NavigateToSecondView()
    {
      Console.WriteLine("Navigating to Second View");
      await _navigationService.Navigate<SecondViewModel>();
    }

    public override void Start()
    {
      _resetTextCommand = new MvxCommand(() => ResetText());
      _startTimerCommand = new MvxCommand(() => StartTimer());
      _navigateToSecondViewCommand = new MvxCommand(async () => await NavigateToSecondView());
      base.Start();
    }

    public MainViewModel(IMvxNavigationService navigationService)
    {
      _navigationService = navigationService;
    }
  }
}
