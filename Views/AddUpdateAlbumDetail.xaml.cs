using Jam_It_.ViewModels;
using JamIT.Views;

namespace Jam_It_.Views;

public partial class AddUpdateAlbumDetail : ContentPage
{
    public AddUpdateAlbumDetail(AddUpdateAlbumDetailViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }
}