using App.Dto;
using MediatR;

namespace App.Application.Commands
{
    public class UpdateProductCommand : IRequest<ProductDto>
    {
        public int ProductId { get; set; }
        public string NewName { get; set; }
        public decimal NewPrice { get; set; }

        public UpdateProductCommand(int productId, string newName, decimal newPrice)
        {
            ProductId = productId;
            NewName = newName;
            NewPrice = newPrice;
        }
    }
}
