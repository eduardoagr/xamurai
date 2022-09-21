
using Prism.Mvvm;

using Xamurai.Model;

namespace Xamurai.ViewModel;
internal class MecedesSpecificViewModel : BindableBase
{
    public Car Car
    {
        get; set;
    }


    public MecedesSpecificViewModel(Car car)
    {
        Car = car;
    }

}
