using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamurai;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class CarView : ContentView, INotifyPropertyChanged
{
    public CarView()
    {
        IsExpanded = true;
        ToggleCollapseCommand = new Command<ContentView>(ToggleCollapse);
        InitializeComponent();
    }

    private void ToggleCollapse(ContentView cv)
    {
        //if (DeviceInfo.Platform == DevicePlatform.Android)
        //{
        //BUG iOS pre7+: doesn't collapse the section, only makes the label invisible

        IsExpanded = !IsExpanded;
        OnPropertyChanged(nameof(IsExpanded));
        //}
    }

    public Command<ContentView> ToggleCollapseCommand
    {
        get;
    }

    public bool IsExpanded
    {
        get; set;
    }
}