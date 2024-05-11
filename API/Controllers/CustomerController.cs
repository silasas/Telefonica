using API.Services.Consolida;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("post-csv-file")]
        public async Task<IActionResult> CsvFile(string customerCode)
        {
            return Ok();
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
