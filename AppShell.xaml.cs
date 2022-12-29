namespace JamIT;
using Jam_It_.Views;
using JamIT.Views;
using System.Collections.ObjectModel;

public partial class AppShell : Shell
{
    public ObservableCollection<dynamic> MenuAlbums { get; set; }
    public AppShell()
	{

        MenuAlbums = new ObservableCollection<dynamic>()
            {
                new {  Name="Album 1" },
                new {  Name="Album 2" },
                new {  Name="Album 3" },
                new {  Name="Album 4" }
            };  

        InitializeComponent();
        Routing.RegisterRoute(nameof(AddUpdateAlbumDetail), typeof(AddUpdateAlbumDetail));
        Routing.RegisterRoute(nameof(AddUpdateSongDetail), typeof(AddUpdateSongDetail));
        Routing.RegisterRoute(nameof(DiscoverPage), typeof(DiscoverPage));
        Routing.RegisterRoute(nameof(AlbumDetail), typeof(AlbumDetail));


    }

    async protected override void OnAppearing()
    {
        base.OnAppearing();

        await Task.Delay(2200);

        var color = FlyoutBackgroundColor;
        FlyoutBackgroundColor = Colors.DarkBlue;
        FlyoutBackgroundColor = color;

    }
}
