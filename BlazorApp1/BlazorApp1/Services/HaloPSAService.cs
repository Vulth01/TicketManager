using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class HaloPSAService
    {
        private readonly HttpClient _httpClient;
        private readonly string _haloApiUrl = "https://your-halo-psa-instance/api/v1";                      // Your HaloPSA instance URL
        private readonly string _apiKey = "your-api-key";                                                   // Replace with your actual API key

        public HaloPSAService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Create or Update a ticket in HaloPSA
        public async Task<bool> CreateOrUpdateTicketAsync(TicketSummary document)
        {
            var ticketData = new
            {
                //title = document.FaultDescription,
                //description = $"Fault Description: {document.FaultDescription}, Site Address: {document.SiteAddress}",
                //priority = "Normal",                                                                        // Adjust this as needed
                //customer_name = document.UserName,
                //customer_email = document.UserEmail,
                //customer_contact = document.UserContactNumber,
                //equipment_make = document.EquipmentMake,
                //equipment_model = document.EquipmentModel,
                //serial_number = document.EquipmentSerialNumber,
                //product_number = document.EquipmentProductNumber,
            };

            var json = JsonConvert.SerializeObject(ticketData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, $"{_haloApiUrl}/tickets");
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            request.Content = content;

            var response = await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode;                                                            // Return whether the request was successful
        }
    }
}

