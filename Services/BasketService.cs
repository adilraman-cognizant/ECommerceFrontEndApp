using System.Net.Http.Json;
using EComBlazor.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EComBlazor.Services{

    public class BasketService{
        private readonly HttpClient _httpClient;

        public BasketService(HttpClient httpClient){
            _httpClient = httpClient;
        }


        public async Task<List<BasketProduct>> GetBasketProductsAsync(string userId)
        {
            // Makes an HTTP GET request to fetch the product list from the API.
            return await _httpClient.GetFromJsonAsync<List<BasketProduct>>($"api/baskets/{userId}");
        }

        public async Task CreateBasketProductAsync(BasketProduct basketProduct){
            Console.WriteLine("BasketService.cs: CreateBasketProductAsync() called");
            await _httpClient.PostAsJsonAsync("api/baskets", basketProduct);
        }

        public async Task DeleteBasketProductAsync(int id){
            await _httpClient.DeleteAsync($"api/baskets/{id}");
        }

    }

}