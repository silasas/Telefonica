using API.Json;
using Newtonsoft.Json;

namespace API.Services.Consolida
{
    public class ConsolidaService
    {
        public async Task<List<Customer_Response_Json>> GetAllCustomers()
        {
            var response = new List<Customer_Response_Json>() { };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7134/api/Gaither/");

                var jsonResponse = client.GetAsync($"{"get-all-customers-union"}").Result;

                if (jsonResponse.IsSuccessStatusCode)
                {
                    var content = await jsonResponse.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        response = JsonConvert.DeserializeObject<List<Customer_Response_Json>>(content);
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

        //public async Task<Customer_Response_Json> UploadCsv()
        //{

        //}
    }
}
