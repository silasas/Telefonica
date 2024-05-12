using Consolida.Models;
using Consolida.Services.Banco1;
using Consolida.Services.Banco2;
using Consolida.Services.Banco3;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Consolida.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaitherController : ControllerBase
    {
        public GaitherController()
        {
            
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-union-customercode")]
        public async Task<IActionResult> GetUnionByCustomerCode(string customerCode)
        {
            //Banco 1 = Customer
            Banco1Service b1s = new Banco1Service();
            var customer = b1s.GetCustomerByCode(customerCode).Result;

            //Banco 2 = Product
            Banco2Service b2s = new Banco2Service();
            var product = b2s.GetProductByCustomerCode(customerCode).Result;

            //Banco 3 = Price
            Banco3Service b3s = new Banco3Service();
            var price = b3s.GetPriceByProductCode(product.Code).Result;

            CustomerProductPrice cpp = new CustomerProductPrice();

            cpp.CustomerCode = customerCode;
            cpp.ProductCode = product.Code;
            cpp.FirstName = customer.FirstName;
            cpp.MiddleName = customer.MiddleName;
            cpp.SurName = customer.SurName;
            cpp.Product = product.Name;
            cpp.Price = price.Price;

            if (cpp != null)
                return Ok(await Task.FromResult(cpp));

            return BadRequest();
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("get-all-customers-union")]
        public async Task<IActionResult> GetAllCustomersUnion()
        {
            //Banco 1 = Customer
            Banco1Service b1s = new Banco1Service();
            var customers = b1s.GetAllCustomer().Result;

            //Banco 2 = Product
            Banco2Service b2s = new Banco2Service();
            var product = b2s.GetAllProducts().Result;

            //Banco 3 = Price
            Banco3Service b3s = new Banco3Service();
            var price = b3s.GetAllPrices().Result;

            List<CustomerProductPrice> list = new List<CustomerProductPrice>();

            foreach (var customer in customers)
            {
                CustomerProductPrice cpp = new CustomerProductPrice();

                cpp.CustomerCode = customer.Code;
                cpp.ProductCode = product.Where(s => s.CustomerCode == customer.Code).Select(s => s.Code).FirstOrDefault().ToString();
                cpp.FirstName = customer.FirstName;
                cpp.MiddleName = customer.MiddleName;
                cpp.SurName = customer.SurName;
                cpp.Product = product.Where(s => s.CustomerCode == customer.Code).Select(s => s.Name).FirstOrDefault().ToString();
                cpp.Price = price.Where(s => s.ProductCode == cpp.ProductCode).Select(s => s.Price).FirstOrDefault();

                list.Add(cpp);
            }

            return Ok(list);
        }

        //[HttpPost("import-csv-file")]
        [HttpPost]
        [AllowAnonymous]
        [Route("import-csv-file")]
        public async Task<IActionResult> CsvFileImport(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
