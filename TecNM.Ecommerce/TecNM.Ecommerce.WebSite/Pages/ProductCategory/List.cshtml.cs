using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.ProductCategory;

public class ListModel : PageModel
{
    private readonly IProductCategoryService _service;
    public List<ProductCategoryDto> ProductCategories { get; set; }

    
    public ListModel(IProductCategoryService service)
    {
        ProductCategories = new List<ProductCategoryDto>();
        _service = service;
    }
    
    public async Task<IActionResult> OnGet()
    {
        //llamada al servicio
        var response = await _service.GetAllAsync();
        ProductCategories = response.Data;

        return Page();
    }
}