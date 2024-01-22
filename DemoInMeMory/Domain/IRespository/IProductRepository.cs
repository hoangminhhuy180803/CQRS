

using Domain.model;

namespace Domain.IRespository
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
    }
}
