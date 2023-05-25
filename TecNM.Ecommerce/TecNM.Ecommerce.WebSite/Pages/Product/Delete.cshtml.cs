using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.Product;

public class Delete : PageModel
{
    [BindProperty] public ProductDto Product { get; set;}
    private readonly IProductService _service;
    public Delete(IProductService service)
    {
        _service = service;
    }
    public async Task<IActionResult> OnGet(int id)
    {
        Product = new ProductDto();
        //Obtener informacion del servicio(API) 
        var response = await _service.GetById(id);
        Product = response.Data;
        if (Product == null)
        {
            return RedirectToPage("/Error");
        }
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        var response = await _service.DeleteAsync(Product.Id);
        return RedirectToPage("./List");
    }
}