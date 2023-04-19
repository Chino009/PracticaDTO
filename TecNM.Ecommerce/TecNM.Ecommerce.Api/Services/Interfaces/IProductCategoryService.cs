using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IProductCategoryService
{
    //Metodo para guardar categorias
    Task<ProductCategoryDto> SaveAsync(ProductCategoryDto category);
    
    //Metodo para Actualizar las categorias
    Task<ProductCategoryDto> UpdateAsync(ProductCategoryDto categoryD);
    
    //Metodo para retonar una lista de categorias
    Task<List<ProductCategoryDto>> GetAllAsync();
    
    //Metodo para retornar el id de las catevorias que borrara
    Task<bool> ProductCategoryExist(int id);
    
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<ProductCategoryDto> GetById(int id); 
}