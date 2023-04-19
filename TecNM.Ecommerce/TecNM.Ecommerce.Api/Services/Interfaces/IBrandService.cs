using TecNM.Ecommerce.Core.Dto;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IBrandService
{
    //Metodo para guardar categorias
    Task<BrandDto> SaveAsync(BrandDto brandDto);
    
    //Metodo para Actualizar las categorias
    Task<BrandDto> UpdateAsync(BrandDto brandDto);
    
    //Metodo para retonar una lista de categorias
    Task<List<BrandDto>> GetAllAsync();
    
    //Metodo para retornar el id de las catevorias que borrara
    Task<bool> BrandExist(int id);
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<BrandDto> GetById(int id); 
}