using dotnet_maui_coin_converter.ViewModel;

namespace dotnet_maui_coin_converter.View;

public partial class CoinConverterSLPage : ContentPage
{
    public CoinConverterSLPage(CoinConverterViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

    }
}