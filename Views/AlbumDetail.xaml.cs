
using JamIT.Repositories;
using JamIT.Views;

namespace Jam_It_.Views;

public partial class AlbumDetail : ContentPage
{
    public AlbumDetail()
    {
        InitializeComponent();
        SongRepository database = new SongRepository();
        SongListView.ItemsSource = database.Songs;

    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }
}