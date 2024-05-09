using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco1.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }


        [StringLength(256)]
        [Display(Name = "Code")]
        public string Code { get; set; } = string.Empty;


        [StringLength(100)]
        public string? FirstName { get; set; } = string.Empty;

        [StringLength(100)]
        public string? MiddleName { get; set; } = string.Empty;

        [StringLength(100)]
        public string? SurName { get; set; } = string.Empty;
    }
}
