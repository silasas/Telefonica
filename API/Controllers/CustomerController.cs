using API.Json;
using API.Services.Consolida;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("post-csv-file")]
        public async Task<IActionResult> CsvFileImport(IFormFile file)
         {
            var filepath = Path.Combine("Files",file.FileName);

            using (Stream fileStream = new FileStream(filepath, FileMode.Create)) 
            {
                file.CopyTo(fileStream);
            }

            ConsolidaService cs = new ConsolidaService();
            var result = cs.ExportCsv(filepath).Result;
            
            if (result == "ok") {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("get-customers")]
        public async Task<IActionResult> GetCustomers()
        {
            // Servidor Consolida
            ConsolidaService cs = new ConsolidaService();
            var result = cs.GetAllCustomers().Result;

            return Ok(result);
        }
    }
}
