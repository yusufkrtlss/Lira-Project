using EntityLayer.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Context
{
    public class DatabaseSeed
    {
        private readonly LiraDb liraContext;
        string baseUrl = "https://yh-finance.p.rapidapi.com/";
        public DatabaseSeed(LiraDb liraContext)
        {
            this.liraContext = liraContext;
        }

        public async void Seed()
        {
            if(!liraContext.Companies.Any())
            {
                List<Companies> companies= new List<Companies>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://yh-finance.p.rapidapi.com/market/v2/get-quotes?region=US&symbols=AMD%2CIBM%2CAAPL%2CAMZN%2CAAPL%2CGOOGLTSLA%2CSHOP%2CF%2CNVDA%2CLUMN%2CCS%2CGOLD%2CBABA%2CRLX%2CAPE%2CBAC%2CMETA%2CLCID%2CT%2CINTC%2CDNA%2CPLTR%2CAAL%2CNOK"),
                    Headers =
                        {
                            { "X-RapidAPI-Key", "8fca6e9c22mshf749152c28189b6p149178jsn244430972a88" },
                            { "X-RapidAPI-Host", "yh-finance.p.rapidapi.com" },
                        },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    companies= JsonConvert.DeserializeObject<List<Companies>>(body);

                    Console.WriteLine(companies);
                }
            }
        }
    }
}
