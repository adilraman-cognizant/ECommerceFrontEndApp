
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EComBlazor.Models;

namespace EComBlazor.Models{
    public class WishListItemDto{
        public int WishlistId { get; set; }
        public Product product { get; set; }
        public bool IsInWishlist { get; set; }
    }
}