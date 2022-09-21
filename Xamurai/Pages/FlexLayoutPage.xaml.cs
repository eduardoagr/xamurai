
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamurai.ViewModel;

namespace Xamurai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            BindingContext = new SampleViewModel();
            InitializeComponent();
        }
    }
}