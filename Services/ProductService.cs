using System.Net.Http.Json;
using EComBlazor.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EComBlazor.Services{


    public class ProductService{
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient){
            _httpClient = httpClient;
        }


        public async Task<List<Product>> GetProductsAsync()
        {
            // Makes an HTTP GET request to fetch the product list from the API.
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");
        }

        public async Task<Product> GetProductAsync(int id)
        {
            // Makes an HTTP GET request to fetch the product details from the API.
            return await _httpClient.GetFromJsonAsync<Product>($"api/products/{id}");
        }


        public async Task<Product> CreateProductAsync(Product product){
            var response = await _httpClient.PostAsJsonAsync("api/products", product);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // Deserialize and return the created product (including the generated Id)
            return await response.Content.ReadFromJsonAsync<Product>();
        }

        public async Task UploadProductImageAsync(int productId, IBrowserFile imageFile)
        {

            // Create a new FormDataContent object
            var content = new MultipartFormDataContent();
            // Add the image file
            var streamContent = new StreamContent(imageFile.OpenReadStream(maxAllowedSize: 1024 * 1024 * 15)); // e.g., 15 MB max
            content.Add(streamContent, "imageFile", imageFile.Name);
            // Send the POST request to the API 
            await _httpClient.PostAsync($"api/products/{productId}/upload-image", content);
        }

        public async Task UpdateProductAsync(int id, Product product){
            await _httpClient.PutAsJsonAsync($"api/products/{id}", product);
        }

        public async Task DeleteProductAsync(int id){
            await _httpClient.DeleteAsync($"api/products/{id}");
        }

    }

}