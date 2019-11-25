using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APIDemo.Models;
using Newtonsoft.Json;

namespace APIDemo.Services
{
    public class RussianHolidayService : IRussianHolidayService
    {
               
        public async Task<RussianHolidayResponse> GetDate(string date)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://datazen.katren.ru") })
            {
                var result = await httpClient.GetStringAsync($"/calendar/day/{date}/");      //MIGHT HAVE TO ADD @Date
                return JsonConvert.DeserializeObject<RussianHolidayResponse>(result);
            }
        }
    }
}
  
