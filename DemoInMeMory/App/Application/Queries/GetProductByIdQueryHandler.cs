
using App.Dto;
using Domain.IRespository;
using Domain.model;
using MediatR;



namespace App.Application.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Task<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if (product == null)
            {
                return null;
            }

            return product;
        }
    }
}
