using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<HouseModel>> GetHousesAsync(string address, string city)
    {
        try
        {
            string apiUrl = $"https://yourserver.com/api/houses?address={Uri.EscapeDataString(address)}&city={Uri.EscapeDataString(city)}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<HouseModel>>(json);
            }
            else
            {
                return new List<HouseModel>();
            }
        }
        catch
        {
            return new List<HouseModel>();
        }
    }
}