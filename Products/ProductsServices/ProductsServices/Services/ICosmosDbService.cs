using ProductsServices.Model;

namespace ProductsServices.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Product>> GetMultipleAsync(string query);
        Task<Product> GetAsync(string id);
        Task AddAsync(Product item);
        Task UpdateAsync(string id, Product item);
        Task DeleteAsync(string id);
    }
}
