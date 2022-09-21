using UIKit;

using Xamarin.Forms;

using Xamurai.Interfaces;
using Xamurai.iOS;

[assembly: Dependency(typeof(StatusBar))]
namespace Xamurai.iOS
{
    public class StatusBar : IStatusBar
    {
        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }
        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }
    }
}