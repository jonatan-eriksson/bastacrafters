using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ParkingApp_FrontEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParkingApp_FrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://localhost:5001/api/v1";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public UserViewModel UserModel { get; set; } = new UserViewModel();
        public bool Parked { get; set; }

        public async Task OnGet()
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var uri = new Uri(_baseUrl + "/location/1");
            try
            {
                var responseString = await _httpClient.GetStringAsync(uri);
                UserModel = JsonConvert.DeserializeObject<UserViewModel>(responseString, settings);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            CheckParked();
        }

        public async Task<IActionResult> OnPostPark(string coords)
        {
            var url = new Uri($"{_baseUrl}/location?coords={coords}");
            try
            {
                using var httpResponse = await _httpClient.PostAsync(url, null);
                httpResponse.EnsureSuccessStatusCode();
            } catch(Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostLeave()
        {
            var url = new Uri($"{_baseUrl}/location?coords=");
            try
            {
                using var httpResponse = await _httpClient.PostAsync(url, null);
                httpResponse.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return RedirectToPage();
        }

        public void CheckParked()
        {
            if (UserModel.CoordinatesWhenParking != null) Parked = true;
        }
    }
}
