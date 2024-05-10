using Consolida.Json.Response;
using Newtonsoft.Json;

namespace Consolida.Services.Banco2
{
    public class Banco2Service
    {
        public async Task<Product_Response_Json> GetProductByCustomerCode(string customerCode)
        {
            var response = new Product_Response_Json { };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7039/api/Product/");

                var jsonResponse = client.GetAsync($"{"get-by-customercode"}{"?customercode="}{customerCode}").Result;

                if (jsonResponse.IsSuccessStatusCode)
                {
                    var content = await jsonResponse.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        response = JsonConvert.DeserializeObject<Product_Response_Json>(content);
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
