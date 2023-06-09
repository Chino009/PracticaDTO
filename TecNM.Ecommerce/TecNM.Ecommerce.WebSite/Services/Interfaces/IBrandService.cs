using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.WebSite.Services.Interfaces;

public interface IBrandService
{
    Task<Response<List<BrandDto>>> GetAllAsync();

    Task<Response<BrandDto>> GetById(int id);

    Task<Response<BrandDto>> SaveAsync(BrandDto brand);

    Task<Response<BrandDto>> UpdateAsync(BrandDto brand);

    Task<Response<bool>> DeleteAsync(int id);
}