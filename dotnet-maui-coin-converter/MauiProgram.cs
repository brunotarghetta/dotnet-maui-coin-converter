using dotnet_maui_coin_converter.Service;
using dotnet_maui_coin_converter.View;
using dotnet_maui_coin_converter.ViewModel;

namespace dotnet_maui_coin_converter;

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
                fonts.AddFont("fa_solid.ttf", "FontAwesome");
            });

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        
        builder.Services.AddSingleton<CoinConverterService>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<CoinConverterViewModel>();
        builder.Services.AddTransient<CoinConverterSLPage>();


        return builder.Build();
	}
}
