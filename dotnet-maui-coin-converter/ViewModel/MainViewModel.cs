using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnet_maui_coin_converter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_maui_coin_converter.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        [ICommand]
        async Task OpenCoinConverter(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(CoinConverterPage)}");
        }
    }
}
