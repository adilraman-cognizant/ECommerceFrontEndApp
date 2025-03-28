using System.Net.Http.Json;
using BlazorBootstrap;
using EComBlazor.Models;
using EComBlazor.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;

namespace EComBlazor.Services{

    public class ProfileService{
        private readonly HttpClient _httpClient;
        

        public ProfileService(HttpClient httpClient){
            _httpClient = httpClient;
        }


        public async Task<UserProfile> GetUserProfileAsync(int userId)
        {
            // Makes an HTTP GET request to fetch the user profile from the API.
            return await _httpClient.GetFromJsonAsync<UserProfile>($"api/userprofiles/{userId}");
        }

    
    }

}
