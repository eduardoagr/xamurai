using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamurai.Interfaces;
using Xamurai.ViewModel;

namespace Xamurai;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ListViewPage : ContentPage
{
    public ListViewPage()
    {
        DependencyService.Get<IStatusBar>().HideStatusBar();
        BindingContext = new SampleViewModel();
        InitializeComponent();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        {
            base.OnSizeAllocated(width, height);

            if (width < height)
            {
                // portrait orientation
                CarsList.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical);

            }
            else if (height < width)
            {
                // landscape orientation
                CarsList.ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal);
            }
        }
    }
}