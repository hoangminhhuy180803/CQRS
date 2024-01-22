using App.Dto;
using MediatR;

namespace App.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
