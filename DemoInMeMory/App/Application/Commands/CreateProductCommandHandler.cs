using App.Dto;

using Domain.Event;
using Domain.IRespository;
using Domain.model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;

        public CreateProductCommandHandler(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
         //   request.Validate();

            var product = new Product(request.Name, request.Price);

            await _productRepository.AddAsync(product);
            await _mediator.Publish(new ProductUpdated(product.Id, product.Name, product.Price), cancellationToken);

            return product;
        }

    }
}
