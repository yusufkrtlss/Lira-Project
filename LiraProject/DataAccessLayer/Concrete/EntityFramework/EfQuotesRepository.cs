using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Context;
using DataAccessLayer.EfRepositories;
using EntityLayer.APIClasses;
using EntityLayer.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfQuotesRepository : GenericRepository<Quotes>, IQuotesDal
    {
        public void InsertFromAPI(Quotes quotes)
        {
            using var c = new LiraDb();
            if (!c.Companies.Any())
            {
                string BaseUrl = "https://yh-finance.p.rapidapi.com/";

                var client = new HttpClient();

                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "8fca6e9c22mshf749152c28189b6p149178jsn244430972a88");
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "yh-finance.p.rapidapi.com");
                string url = string.Format("market/v2/get-quotes?region=US&symbols=" +
                    "AMD%2CIBM%2CAAPL%2CAMZN%2CAAPL%2CGOOGLTSLA%2CSHOP%2CF%2CNVDA%2CLUMN%2CCS%2CGOLD%2CBABA%2CRLX%2CAPE%2CBAC%2CMETA%2CLCID%2CT%2CINTC%2CDNA%2CPLTR%2CAAL%2CNOK%2CRIG%2CGOOG%2CKMI%2CWBD%2CNU%2CLU%2CC%2CHPE%2CU%2CCLF%2CABEV%2CSLB%2COXY%2CPTON%2CMU");
                HttpResponseMessage resp = client.GetAsync(url).Result;
                if (resp.IsSuccessStatusCode)
                {
                    var body = resp.Content.ReadAsStringAsync().Result;
                    quotes = JsonConvert.DeserializeObject<Quotes>(body);

                    

                    //JsonArray jsonArray = new JsonArray();
                    //jsonArray.Add(quotes);

                    foreach (var item in quotes.quoteResponse.result)
                    {
                        Companies companies = new Companies()
                        {
                            CompanyName = item.longName,
                            CompanySymbol = item.symbol,
                            CompanyRegularMarketPrice= item.regularMarketPrice,
                            CompanyRegularMarketChange= item.regularMarketChange,
                            CompanyRegularMarketChangePercent= item.regularMarketChangePercent,
                            CompanyRegularMarketVolume= item.regularMarketVolume,
                            CompanyRegularMarketDayLow= item.regularMarketDayLow,
                            CompanyRegularMarketDayHigh= item.regularMarketDayHigh,
                            CompanyBalance=item.totalCash,
                            CompanyEBITDA=item.ebitda,
                            CompanyIncomeStatement=item.revenue,
                            CompanyProfit=item.marketCap,
                            CompanyPriceGainRate=item.priceToSales,
                            CompanyInformation=item.quoteSourceName

                            
                        };
                        c.Add(companies);
                        c.SaveChanges();
                    }

                    
                }




            }

        }
    }
}
