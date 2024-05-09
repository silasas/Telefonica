using Banco1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banco1.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-customer-list")]
        public async Task<IActionResult> List()
        {
            var result = await _context.Customer.ToListAsync();

            if(result != null)
                return Ok(result);

            return BadRequest();
        }
    }
}
