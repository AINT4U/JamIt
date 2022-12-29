using Microsoft.Extensions.Logging;
using Jam_It_.Models;
using Jam_It_.Services;
using Jam_It_.ViewModels;
using Jam_It_.Views;

namespace JamIT;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        // Views Registration
        builder.Services.AddSingleton<AlbumListPage>();
        builder.Services.AddSingleton<AddUpdateAlbumDetail>();

        // Services
        builder.Services.AddSingleton<IAlbumService, AlbumService>();

        //View Models
        builder.Services.AddSingleton<AlbumListPageViewModel>();
        builder.Services.AddSingleton<AddUpdateAlbumDetailViewModel>();

        return builder.Build();
	}
}
