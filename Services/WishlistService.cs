using System.Net.Http.Json;
using EComBlazor.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EComBlazor.Services{

    public class WishlistService{
        private readonly HttpClient _httpClient;

        public WishlistService(HttpClient httpClient){
            _httpClient = httpClient;
        }


        public async Task<List<WishList>> GetWishlistAsync(string userId)
        {
            //
            return await _httpClient.GetFromJsonAsync<List<WishList>>($"api/wishlists/{userId}");
        }

        public async Task AddWishlistProductAsync(WishList wProduct){
            Console.WriteLine("Wishlist service.cs: () called");
            await _httpClient.PostAsJsonAsync("api/wishlists", wProduct);
        }

        public async Task DeleteWishlistProductAsync(int id){
            await _httpClient.DeleteAsync($"api/wishlists/{id}");
        }

    }

}