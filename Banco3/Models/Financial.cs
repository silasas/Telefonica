using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco3.Models
{
    [Table("Financial")]
    public class Financial
    {
        [Key]
        public int Id { get; set; }


        [StringLength(256)]
        [Display(Name = "Code")]
        public string Code { get; set; } = string.Empty;


        [StringLength(256)]
        [Display(Name = "Code")]
        public string ProductCode { get; set; } = string.Empty;


        [Display(Name = "Price")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:C2}")]
        public decimal Price { get; set; } = 0.00m;
    }
}
