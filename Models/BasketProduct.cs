using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComBlazor.Models {
    public class BasketProduct {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty; 
        [Required]
        public int ProductId { get; set; }
        [Required]
        [Range(1, 9999)]
        public int Quantity { get; set; } = 1;
        public decimal UnitPrice { get; set; }
    }
}