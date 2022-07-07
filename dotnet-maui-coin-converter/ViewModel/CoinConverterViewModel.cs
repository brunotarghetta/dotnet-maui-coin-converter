using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dotnet_maui_coin_converter.Service;
using Microsoft.Maui.Networking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_maui_coin_converter.ViewModel
{
    public partial class CoinConverterViewModel : ObservableObject
    {
        [ObservableProperty]
        List<string> coins;


        [ObservableProperty]
        string coinFrom;

        [ObservableProperty]
        string coinTo;

        [ObservableProperty]
        decimal valueFrom;


        [ObservableProperty]
        decimal valueTo;

        IConnectivity connectivity;

        CoinConverterService coinConverterService;


        public CoinConverterViewModel(IConnectivity connectivity, CoinConverterService coinConverterService)
        {
            coins = new List<string> { "USD", "BTC", "ETH" };
            this.connectivity = connectivity;
            this.coinConverterService = coinConverterService;
        }

        [ICommand]
        async void Convert(string s)
{
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("No connectivity!",
                    $"Please check internet and try again.", "OK");
                return;
            }

            var exchangeRate = await coinConverterService.GetExchangeRate(CoinFrom,CoinTo);

            ValueTo =Math.Round( exchangeRate * valueFrom,5);

        }
    }
}
