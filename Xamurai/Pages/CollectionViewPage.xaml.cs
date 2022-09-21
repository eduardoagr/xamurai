
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamurai.ViewModel;
namespace Xamurai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewPage : ContentPage
    {
        public CollectionViewPage()
        {
            BindingContext = new SampleViewModel();
            InitializeComponent();
        }
    }
}