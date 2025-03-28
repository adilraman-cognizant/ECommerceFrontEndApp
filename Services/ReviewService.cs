using System.Net.Http.Json;
using BlazorBootstrap;
using EComBlazor.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EComBlazor.Services{

    public class ReviewService{
        private readonly HttpClient _httpClient;

        public ReviewService(HttpClient httpClient){
            _httpClient = httpClient;
        }


        public async Task<List<Review>> GetProductReviewsAsync(int prodId)
        {
            // Makes an HTTP GET request to fetch the review list from the API.
            return await _httpClient.GetFromJsonAsync<List<Review>>($"api/reviews/{prodId}");
        }

        public async Task AddReviewAsync(Review review)
        {
            // Makes an HTTP POST request to add a new review to the API.
            await _httpClient.PostAsJsonAsync("api/reviews", review);
        }

    }

}
