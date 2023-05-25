using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.WebSite.Services.Interfaces;

public interface IProductService
{
    Task<Response<List<ProductDto>>> GetAllAsync();

    Task<Response<ProductDto>> GetById(int id);

    Task<Response<ProductDto>> SaveAsync(ProductDto product);

    Task<Response<ProductDto>> UpdateAsync(ProductDto product);

    Task<Response<bool>> DeleteAsync(int id); 
}