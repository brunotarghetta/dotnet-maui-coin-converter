using dotnet_maui_coin_converter.ViewModel;

namespace dotnet_maui_coin_converter;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}

