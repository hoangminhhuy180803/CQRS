using Domain.Model;
using Microsoft.EntityFrameworkCore;


public class BookDbContext : DbContext
{
   

    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options) { }
    public DbSet<Books> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Books>().HasData(
           new Books
           {
               Id = 1,
               Name = "Book1",
               Authors = "Author1",
               Quantity = 10 // Giả sử Quantity là một thuộc tính mới và bạn đặt giá trị mặc định là 10
           },
           new Books
           {
               Id = 2,
               Name = "Book2",
               Authors = "Author2",
               Quantity = 20
           },
           new Books
           {
               Id = 3,
               Name = "Book3",
               Authors = "Author3",
               Quantity = 15
           });
    }
}
