using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco2.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [StringLength(256)]
        [Display(Name = "Code")]
        public string Code { get; set; } = string.Empty;


        [Display(Name = "Product name")]
        public string Name { get; set; } = string.Empty;


        [StringLength(256)]
        [Display(Name = "Code")]
        public string CustomerCode { get; set; } = string.Empty;
    }
}
