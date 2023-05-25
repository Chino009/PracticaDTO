using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.ProductCategory;

public class Delete : PageModel
{
    [BindProperty] public ProductCategoryDto ProductCategory { get; set;}
    private readonly IProductCategoryService _service;
    public Delete(IProductCategoryService service)
    {
        _service = service;
    }
    public async Task<IActionResult> OnGet(int id)
    {
        ProductCategory = new ProductCategoryDto();
        //Obtener informacion del servicio(API) 
        var response = await _service.GetById(id);
        ProductCategory = response.Data;
        if (ProductCategory == null)
        {
            return RedirectToPage("/Error");
        }
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        var response = await _service.DeleteAsync(ProductCategory.Id);
        return RedirectToPage("./List");
    }
}