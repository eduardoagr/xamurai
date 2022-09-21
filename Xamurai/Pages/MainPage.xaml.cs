using Xamarin.Forms;

using Xamurai.Interfaces;

namespace Xamurai;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        DependencyService.Get<IStatusBar>().ShowStatusBar();
    }

}