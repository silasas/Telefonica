using Consolida.Json.Response;
using Newtonsoft.Json;

namespace Consolida.Services.Banco3
{
    public class Banco3Service
    {
        public async Task<Price_Response_Json> GetPriceByProductCode(string productCode)
        {
            var response = new Price_Response_Json { };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7045/api/Financial/");

                var jsonResponse = client.GetAsync($"{"get-by-productcode"}{"?productcode="}{productCode}").Result;

                if (jsonResponse.IsSuccessStatusCode)
                {
                    var content = await jsonResponse.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        response = JsonConvert.DeserializeObject<Price_Response_Json>(content);
                        return response;
                    }

                    else
                    {
                        return response;
                    }
                }

                else
                {
                    return response;
                }
            }

            catch
            {
                return response = null;
            }
        }
    }
}
