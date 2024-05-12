using Consolida.Models;
using CsvHelper.Configuration;

namespace Consolida.MapeamentoCsv
{
    public class CustomerCsv : ClassMap<Customer>
    {
        public CustomerCsv()
        {
            Map(s => s.Id).Name("Id");
            Map(s => s.CustomerCode).Name("CustomerCode");
            Map(s => s.ProductCode).Name("ProductCode");
            Map(s => s.FirstName).Name("FirstName");
            Map(s => s.MiddleName).Name("MiddleName");
            Map(s => s.SurName).Name("SurName");
            Map(s => s.Product).Name("Product");
            Map(s => s.Price).Name("Price");
        }
    }
}
