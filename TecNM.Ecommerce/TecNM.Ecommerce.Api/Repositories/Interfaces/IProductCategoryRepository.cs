using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IProductCategoryRepository
{
    //Metodo para guardar categorias
    Task<ProductCategory> SaveAsync(ProductCategory category);
    
    //Metodo para Actualizar las categorias
    Task<ProductCategory> UpdateAsync(ProductCategory category);
    
    //Metodo para retonar una lista de categorias
    Task<List<ProductCategory>> GetAllAsync();
    
    //Metodo para retornar el id de las catevorias que borrara
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<ProductCategory> GetById(int id); 
}