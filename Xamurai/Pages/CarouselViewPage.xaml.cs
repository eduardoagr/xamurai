
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamurai.ViewModel;

namespace Xamurai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewPage : ContentPage
    {
        public CarouselViewPage()
        {
            BindingContext = new SampleViewModel();
            InitializeComponent();
        }
    }
}