using API.Json;
using Newtonsoft.Json;
using System.Net.Http.Headers;

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

        public async Task<string> ExportCsv(string path)
        {
            try
            {
                using var client = new HttpClient();
                var apiUrl = new Uri("https://localhost:7134/api/Gaither/import-csv-file");

                string filePath = path;
                using var form = new MultipartFormDataContent();
                using var fileContent = new ByteArrayContent(await File.ReadAllBytesAsync(filePath));
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                form.Add(fileContent, "file", Path.GetFileName(filePath));

                var response = await client.PostAsync(apiUrl, form);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return "ok";
                }

                else
                {
                    return "fail";
                }
            }

            catch
            {
                return null;
            }
        }
    }
}
