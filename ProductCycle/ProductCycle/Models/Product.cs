using System.ComponentModel.DataAnnotations;

namespace ProductCycle.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName {  get; set; }

        [Required]
        public DateTime MFGDate { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }
        
        [Required]
        public DateTime CreateOn { get; set; }

        [Required]
        public bool Status {  get; set; }
    }
}
