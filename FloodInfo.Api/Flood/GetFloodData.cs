using FloodInfo.Api.Flood;
using FloodInfo.lib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Giphy.Api
{
    public class GetFloodData : IGetFloodData
    {
        public async Task<string> ReturnFloodData(string searchCritera)
        {
            using (var client = new HttpClient())
            {
                var url = new Uri($"http://environment.data.gov.uk/flood-monitoring/id/floods?county={searchCritera}"); 

                var response = await client.GetAsync(url);

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                var rawData = JsonConvert.DeserializeObject<FloodModel>(json);
                if (rawData.items.Count == 0) return "no flood data";
                return rawData.items[0].message;
            }
        }
    }
}
