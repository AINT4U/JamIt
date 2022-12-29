
using JamIT.Views;

namespace Jam_It_.Views;

public partial class DiscoverPage : ContentPage
{
    public DiscoverPage()
    {
        InitializeComponent();
    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }
}