using System.Collections.Generic;

using Xamarin.Forms;

using Xamurai.Model;

namespace Xamurai.ViewModel;

public class MainPageViewModel
{
    #region Fields
    public List<CustomBton> CustomBtons
    {
        get; set;
    }
    #endregion

    #region Commands

    public Command OpenListViewCommand
    {
        get; set;
    }

    public Command OpenCollectionViewCommand
    {
        get; set;
    }

    public Command OpenCarouselViewCommand
    {
        get; set;
    }

    public Command OpenPagedCollectionViewCommand
    {
        get; set;
    }

    public Command OpenFlexLayoutViewCommand
    {
        get; set;
    }

    #endregion

    public MainPageViewModel()
    {
        InitList();
    }

    #region Helper methods
    private void InitList()
    {
        CustomBtons = new List<CustomBton>()
         {
             new CustomBton
             {
                 Command = new Command(OpenCollectionView),
                 Text = "Collection View"
             },
             new CustomBton
             {
                 Command =   new Command(OpenCarouselView),
                 Text = "Carousel View"
             },
             new CustomBton
             {
                 Command = new Command(OpenFlexLayoutView),
                 Text="Flex Layout View"
             },
             new CustomBton
             {
                 Command = new Command(OpenPagedCollectionView),
                 Text="Challenge #1: Paged Collection View"
             },
             new CustomBton
             {
                 Command = new Command(OpenListView),
                 Text = "Challenge #2: Update the Xaml"
             },
         };
    }

    #endregion

    #region Navigate methods

    private void OpenListView()
    {
        Application.Current.MainPage.Navigation.PushAsync(new ListViewPage());
    }

    private void OpenCollectionView()
    {
        Application.Current.MainPage.Navigation.PushAsync(new CollectionViewPage());
    }

    private void OpenCarouselView()
    {
        Application.Current.MainPage.Navigation.PushAsync(new CarouselViewPage());
    }

    private void OpenFlexLayoutView()
    {
        Application.Current.MainPage.Navigation.PushAsync(new FlexLayoutPage());
    }

    private void OpenPagedCollectionView()
    {
        Application.Current.MainPage.Navigation.PushAsync(new PagedCollectionPage());
    }

    #endregion
}
