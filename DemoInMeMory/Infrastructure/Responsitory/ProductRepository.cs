
using Domain.IRespository;
using Domain.model;
using Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly DBContext _dbContext;

    public ProductRepository(DBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _dbContext.Products.FindAsync(id);
    }

    public async Task AddAsync(Product product)
    {
         _dbContext.Products.Add(product);
        await SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        _dbContext.Products.Update(product);
        await SaveChangesAsync();
    }

    private async Task SaveChangesAsync()
    {
        if (_dbContext.ChangeTracker.HasChanges())
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
