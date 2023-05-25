using Newtonsoft.Json;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Http;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Services;

public class BrandService: IBrandService
{
    private readonly string _baseurl = "https://localhost:7262/";
    private readonly string _endpoint = "api/BrandCrontroller";

    public BrandService()
    {
    }
    public async Task<Response<List<BrandDto>>> GetAllAsync()
    {
        var url = $"{_baseurl}{_endpoint}";
        var client = new HttpClient();
        var res = await client.GetAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Response<List<BrandDto>>>(json);
        return response;
    }
    public async Task<Response<BrandDto>> GetById(int id)
    {
        var url = $"{_baseurl}{_endpoint}/{id}";
        var client = new HttpClient();
        var res = await client.GetAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Response<BrandDto>>(json);
        return response;
    }
    public async Task<Response<BrandDto>> SaveAsync(BrandDto brand)
    {
        var url = $"{_baseurl}{_endpoint}";
        var jsonRequest = JsonConvert.SerializeObject(brand);
        var content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");
        var client = new HttpClient();
        var res = await client.PostAsync(url, content);
        var json = await res.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Response<BrandDto>>(json);
        return response;
    }
    public async Task<Response<BrandDto>> UpdateAsync(BrandDto brand)
    {
        var url = $"{_baseurl}{_endpoint}";
        var jsonRequest = JsonConvert.SerializeObject(brand);
        var content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");
        var client = new HttpClient();
        var res = await client.PutAsync(url, content);
        var json = await res.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Response<BrandDto>>(json);
        return response;
    }
    public async Task<Response<bool>> DeleteAsync(int id)
    {
        var url = $"{_baseurl}{_endpoint}/{id}";
        var client = new HttpClient();
        var res = await client.DeleteAsync(url);
        var json = await res.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Response<bool>>(json);
        return response;
    }
}