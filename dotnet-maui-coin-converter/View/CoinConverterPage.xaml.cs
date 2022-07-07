using dotnet_maui_coin_converter.ViewModel;

namespace dotnet_maui_coin_converter.View;

public partial class CoinConverterPage : ContentPage
{
	public CoinConverterPage(CoinConverterViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;

    }
}