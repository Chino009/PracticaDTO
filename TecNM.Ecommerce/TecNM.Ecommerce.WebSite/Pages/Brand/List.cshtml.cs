using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.Brand;

public class ListModel : PageModel
{
    private readonly IBrandService _service;
    public List<BrandDto> Brand { get; set; }

    
    public ListModel(IBrandService service)
    {
        Brand = new List<BrandDto>();
        _service = service;
    }
    
    public async Task<IActionResult> OnGet()
    {
        //llamada al servicio
        var response = await _service.GetAllAsync();
        Brand = response.Data;

        return Page();
    }
}