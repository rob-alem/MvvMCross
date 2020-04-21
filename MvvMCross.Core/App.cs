using MvvmCross.ViewModels;
using MvvMCross.Core.ViewModels;

namespace MvvMCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}
