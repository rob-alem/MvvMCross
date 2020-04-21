using AppKit;
using Foundation;
using MvvmCross.Platforms.Mac.Core;
using MvvMCross.Core;

namespace MvvmCross.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxMacSetup<App>, App>
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            MvxMacSetupSingleton.EnsureSingletonAvailable(this, MainWindow).EnsureInitialized();
            RunAppStart();
            base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
