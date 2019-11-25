using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APIDemo.Models;
using Newtonsoft.Json;

namespace APIDemo.Services
{
    public class DogService : IDogService
    {
        public async Task<DogResponse> GetDog()
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://dog.ceo") })
            {
                var result = await httpClient.GetStringAsync("/api/breeds/image/random");
                return JsonConvert.DeserializeObject<DogResponse>(result);
            }
        }
    }
}
