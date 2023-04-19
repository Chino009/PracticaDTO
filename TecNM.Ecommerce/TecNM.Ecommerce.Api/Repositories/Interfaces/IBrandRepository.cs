using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IBrandRepository
{
    //Metodo para guardar categorias
    Task<Brand> SaveAsync(Brand brand);
    
    //Metodo para Actualizar las categorias
    Task<Brand> UpdateAsync(Brand brand);
    
    //Metodo para retonar una lista de categorias
    Task<List<Brand>> GetAllAsync();
    
    //Metodo para retornar el id de las catevorias que borrara
    Task<bool> DeleteAsync(int id);
    
    //Metodo para obtener una categoria por id
    Task<Brand> GetById(int id);  
}