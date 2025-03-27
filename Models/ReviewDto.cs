using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EComBlazor.Models;

namespace EComBlazor.Models{
    public class ReviewDto{
        public int ReviewId { get; set; }
        public Product product { get; set; }
        public UserProfile user { get; set; }
        public int Rating { get; set; } 
        public string? Comment { get; set; }
    }
}