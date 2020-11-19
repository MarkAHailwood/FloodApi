using System;
using System.Collections.Generic;
using System.Text;

namespace FloodInfo.lib.Flood
{
    class GetFloodData : IGetFloodData
    {
        public async Task<flood> ReturnRandomGifBasedOnTag(string searchCritera)
        {
            const string giphyKey = "";

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?api_key={giphyKey}&q={searchCritera}&limit=1");

                var response = await client.GetAsync(url);

                string json;
                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}
