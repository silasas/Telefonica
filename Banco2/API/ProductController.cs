using Banco2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banco2.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-product-list")]
        public async Task<IActionResult> List()
        {
            var result = await _context.Product.ToListAsync();

            if (result != null)
                return Ok(result);

            return BadRequest();
        }
    }
}
