using Banco3.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banco3.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FinancialController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-financial-list")]
        public async Task<IActionResult> List()
        {
            var result = await _context.Financial.ToListAsync();

            if (result != null)
                return Ok(result);

            return BadRequest();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("get-by-code")]
        public async Task<IActionResult> GetByCode(string code)
        {
            var result = await _context.Financial.Where(s => s.Code == code).FirstOrDefaultAsync();

            if (result != null)
                return Ok(result);

            return BadRequest();
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-by-productcode")]
        public async Task<IActionResult> GetByProductCode(string productCode)
        {
            var result = await _context.Financial.Where(s => s.ProductCode == productCode).FirstOrDefaultAsync();

            if (result != null)
                return Ok(result);

            return BadRequest();
        }
    }
}
