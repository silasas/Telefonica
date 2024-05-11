using Consolida.Json.Response;
using Newtonsoft.Json;

namespace Consolida.Services.Banco1
{
    public class Banco1Service
    {
        public async Task<Customer_Response_Json> GetCustomerByCode(string customerCode)
        {
            var response = new Customer_Response_Json { };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7270/api/Customer/");

                var jsonResponse = client.GetAsync($"{"get-by-code"}{"?code="}{customerCode}").Result;

                if (jsonResponse.IsSuccessStatusCode)
                {
                    var content = await jsonResponse.Content.ReadAsStringAsync();

                    if (!string.IsNullOrEmpty(content))
                    {
                        response = JsonConvert.DeserializeObject<Customer_Response_Json>(content);
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


        public async Task<List<Customer_Response_Json>> GetAllCustomer()
        {
            var response = new List<Customer_Response_Json>() { };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7270/api/Customer/");

                var jsonResponse = client.GetAsync($"{"get-customer-list"}").Result;

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
    }
}
