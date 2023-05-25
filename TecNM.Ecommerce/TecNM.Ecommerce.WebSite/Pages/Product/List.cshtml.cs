using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.Product;

public class ListModel : PageModel
{
    private readonly IProductService _service;
    public List<ProductDto> Products { get; set; }

    
    public ListModel(IProductService service)
    {
        Products = new List<ProductDto>();
        _service = service;
    }

    public async Task<IActionResult> OnGet()
    {
        //llamada al servicio
        var response = await _service.GetAllAsync();
        Products = response.Data;

        return Page();
    }
}