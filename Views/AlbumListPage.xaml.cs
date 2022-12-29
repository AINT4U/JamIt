namespace Jam_It_.Views;
using Jam_It_.ViewModels;
using JamIT.Views;

public partial class AlbumListPage : ContentPage
{
	protected AlbumListPageViewModel _viewModel;
	public AlbumListPage(AlbumListPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		this.BindingContext = viewModel;
	}
	
	

    protected override void OnAppearing()
    {
        base.OnAppearing();	
		_viewModel.GetAlbumListCommand.Execute(null);
    }

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var profile = new Profile();
        await Navigation.PushAsync(profile);
    }
}