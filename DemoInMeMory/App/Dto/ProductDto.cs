using App.Application.Commands;
using App.Dto;

namespace App.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public static class ProductDtoExtensions
    {
        public static ProductDto ToProductDto(this CreateProductCommand command)
        {
            return new ProductDto
            {
                Name = command.Name,
                Price = command.Price
            };
        }
    }
}
