using dotnet_maui_coin_converter.View;

namespace dotnet_maui_coin_converter;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(CoinConverterSLPage), typeof(CoinConverterSLPage));
    }
}
