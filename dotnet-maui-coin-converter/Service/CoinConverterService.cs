using dotnet_maui_coin_converter.Model;
using System.Net.Http.Json;

namespace dotnet_maui_coin_converter.Service
{
    public class CoinConverterService
    {
        HttpClient httpClient;
        public CoinConverterService()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<decimal> GetExchangeRate(string coinFrom, string coinTo)
        {
            ExchangeRate exchangeRate = new ExchangeRate();
            var response = await httpClient.GetAsync($"https://rest.coinapi.io/v1/exchangerate/{coinFrom}/{coinTo}?apikey=7B576B5F-59CC-4A29-B11E-061623809166");
            if (response.IsSuccessStatusCode)
            {
                exchangeRate = await response.Content.ReadFromJsonAsync<ExchangeRate>();

                //var result = response.Content.ReadAsStringAsync();

                
            }

            return (decimal)exchangeRate.rate;
        }

    }
}
