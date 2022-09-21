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
        ToggleCollapseCommand = new Command<Frame>(ToggleCollapse);
        InitializeComponent();
    }

    private void ToggleCollapse(Frame MyContent)
    {
        if (!IsExpanded)
        {
            MyContent.LayoutTo(new Rectangle(MyContent.Bounds.X, MyContent.Bounds.Y, MyContent.Bounds.Width, 300), 500, Easing.CubicOut);
            IsExpanded = true;
            OnPropertyChanged(nameof(IsExpanded));
        }
        else
        {
            MyContent.LayoutTo(new Rectangle(MyContent.Bounds.X, MyContent.Bounds.Y, MyContent.Bounds.Width, 0), 500, Easing.CubicIn);
            IsExpanded = false;

            OnPropertyChanged(nameof(IsExpanded));
        }
    }

    public Command<Frame> ToggleCollapseCommand
    {
        get;
    }

    public int ta
    {
        get; set;
    }

    public bool IsExpanded
    {
        get; set;
    }
}