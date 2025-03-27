using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EComBlazor.Models;

namespace EComBlazor.Models {
    public class BasketProductDto {
        public int BasketProductId { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    
    }
}