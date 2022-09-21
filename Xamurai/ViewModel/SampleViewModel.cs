using System;
using System.Collections.ObjectModel;
using System.Linq;

using Prism.Mvvm;

using Xamarin.Forms;

using Xamurai.Model;
using Xamurai.Pages;
using Xamurai.Views;

namespace Xamurai.ViewModel;

public class SampleViewModel : BindableBase
{

    public Command<Car> PressedCommand
    {
        get; set;
    }

    public Command<Car> LongPressedCommand
    {
        get; set;
    }
    public Command<Car> DeleteCommand
    {
        get; set;
    }

    public Car SelectedCar
    {
        get; set;
    }

    public SampleViewModel()
    {
        DeleteCommand = new Command<Car>(DeleteAction);
        LongPressedCommand = new Command<Car>(LongPressedAction);
        PressedCommand = new Command<Car>(PressAction);
        GridSpan = Device.Idiom == TargetIdiom.Phone ? 1 : 2;
        BuildCars();
    }

    private void DeleteAction(Car obj)
    {
        Cars.Remove(obj);
    }

    private async void PressAction(Car obj)
    {
        if (obj != null && obj.Make == CarMake.Mercedes)
        {
            var MercedesView = new MecedesSpecificView()
            {
                BindingContext = new MecedesSpecificViewModel(obj)
            };
            await Application.Current.MainPage.Navigation.PushAsync(MercedesView);
        }
        else
        {
            var DetailsPage = new ListViewDetailPage
            {
                BindingContext = new ListViewDetailPageViewModel(obj)
            };
            await Application.Current.MainPage.Navigation.PushAsync(DetailsPage);

        }
    }

    private async void LongPressedAction(Car obj)
    {
        var ans = await Application.Current.MainPage.DisplayAlert("Warning", "do you want to delete?", "OK", "Cancel");

        if (ans)
        {
            Cars.Remove(obj);
        }
    }


    private int _gridSpan;

    public int GridSpan
    {
        get => _gridSpan;
        set => SetProperty(ref _gridSpan, value);
    }

    private void BuildCars()
    {
        Cars = new ObservableCollection<Car>
        {
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Notes = "test car", Description = "Some description", Color = Color.Black },
            new Car { Abbreviation = "BMW", Make=CarMake.BMW, Name = "X5", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 10)), Color = Color.Purple },
            new Car { Abbreviation = "M", Make=CarMake.Mercedes, Name = "AMG C Class", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.CornflowerBlue},
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Brown },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.Orange },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.DarkBlue },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 7)), Color = Color.DarkOrange },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.OrangeRed },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 4)), Color = Color.Violet},
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 2)), Color = Color.DarkSalmon },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Green },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 6)), Color = Color.GreenYellow},
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 3)), Color = Color.LawnGreen},
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.SkyBlue },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = string.Concat(Enumerable.Repeat($"Some description {Environment.NewLine}", 5)), Color = Color.LightCyan },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.PaleTurquoise },
            new Car { Abbreviation = "VW", Make=CarMake.VolksWagen, Name = "Polo", Description = "Some description", Color = Color.Purple },

        };
    }

    private ObservableCollection<Car> _cars;

    public ObservableCollection<Car> Cars
    {
        get => _cars;
        set => SetProperty(ref _cars, value);
    }

}
