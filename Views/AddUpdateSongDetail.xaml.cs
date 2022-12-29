using JamIT;
using JamIT.Views;

namespace Jam_It_.Views;

public partial class AddUpdateSongDetail : ContentPage
{
    public AddUpdateSongDetail()
    {
        InitializeComponent();
    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }

    async void CreatedAction(object sender, EventArgs e)
    {
        var home = new MainPage();
        await Navigation.PushAsync(home);
    }

    void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
    {
        double value = args.NewValue;
        displayLabel.Text = String.Format("{0}", value);
    }
}