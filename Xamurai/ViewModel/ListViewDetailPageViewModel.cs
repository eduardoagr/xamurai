using Prism.Mvvm;

using Xamurai.Model;

namespace Xamurai.ViewModel;
public class ListViewDetailPageViewModel : BindableBase
{
    public Car Car
    {
        get; set;
    }


    public ListViewDetailPageViewModel(Car car)
    {
        Car = car;
    }
}
