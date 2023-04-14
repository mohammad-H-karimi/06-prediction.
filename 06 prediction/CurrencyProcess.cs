using currency1;
using currency2;
using currency3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace currency4
{
    public class currencyprocess
    {
        public static async Task<currencymodel> currencyinformation()
        {
            string url = "https://api.kucoin.com/api/v1/market/stats?symbol=BTC-USDT";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    currencyresultmodel result = await response.Content.ReadAsAsync<currencyresultmodel>();
                    return result.data;
                }
                else
                    throw new Exception(response.ReasonPhrase);

            }
        }
    }
}
