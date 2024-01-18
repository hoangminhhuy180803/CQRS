using Domain.IRespositories;
using Domain.Model;

namespace Infrastructure.Responsitories
{
    public class BookRespository : IBookResponsitory
    {
        private readonly BookDbContext _dbContext;

        public BookRespository(BookDbContext dbContext) {
            _dbContext = dbContext;
        }
        public void Add(Books books)
        {
            _dbContext.Books.Add(books);
            _dbContext.SaveChanges();
        }

        public bool CheckExist(int id)
        {
            var Exist = _dbContext.Books.Any(x => x.Id == id);
            if (Exist)
            {
                return true;
            }
            return false;
        }

        public void Delete(int id)
        {
            _dbContext.Remove(id);
            _dbContext.SaveChanges();

        }

        public Books Get(int id)
        {
#pragma warning disable CS8603
            return _dbContext.Books.Find(id);
#pragma warning restore CS8603 
        }

        public void Update(Books book)
        {
           _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }
        public bool UpdateBooks(int bookId, int quantity)
        {
            var exist = CheckExist(bookId);
            if (exist)
            {
                var product = _dbContext.Books.Find(bookId);
                if (product == null)
                {
                    throw new($"Cannot find a product with id : {bookId}");
                }
                else
                {
                    product.Quantity = quantity;
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
