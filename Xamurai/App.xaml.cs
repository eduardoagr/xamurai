using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: ExportFont("OpenSans-Italic.ttf", Alias = "SansItalic")]
[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "SansBold")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "SansRegular")]
[assembly: ExportFont("OpenSans-Bold.ttf", Alias = "SansRegular")]
[assembly: ExportFont("materialdesignicons.ttf", Alias = "ma")]
[assembly: ExportFont("FontAwesome.otf", Alias = "fa")]

namespace Xamurai;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

    protected override void OnStart()
    {
        // Handle when your app starts
    }

    protected override void OnSleep()
    {
        // Handle when your app sleeps
    }

    protected override void OnResume()
    {
        // Handle when your app resumes
    }
}
