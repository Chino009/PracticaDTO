using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.WebSite.Services.Interfaces;

namespace TecNM.Ecommerce.WebSite.Pages.Brand;

public class Delete : PageModel
{
    [BindProperty] public BrandDto Brand { get; set;}
    private readonly IBrandService _service;
    public Delete(IBrandService service)
    {
        _service = service;
    }
    public async Task<IActionResult> OnGet(int id)
    {
        Brand = new BrandDto();
        //Obtener informacion del servicio(API) 
        var response = await _service.GetById(id);
        Brand = response.Data;
        
        if (Brand == null)
        {
            return RedirectToPage("/Error");
        }
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        var response = await _service.DeleteAsync(Brand.Id);
        return RedirectToPage("./List");
    }
}