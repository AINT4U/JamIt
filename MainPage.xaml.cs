namespace JamIT;

using Jam_It_.Models;
using Jam_It_.ViewModels;
using JamIT.Views;
using System.Collections.ObjectModel;



public partial class MainPage : ContentPage
{
    public ObservableCollection<dynamic> MenuAlbums { get; set; }

    public MainPage()
	{
		InitializeComponent();


    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }
}

