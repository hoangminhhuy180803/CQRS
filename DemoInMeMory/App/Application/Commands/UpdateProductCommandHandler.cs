using App.Dto;
using Domain.Event;
using Domain.IRespository;
using Domain.model;
using MediatR;

namespace App.Application.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }

        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var existingProduct = await _productRepository.GetByIdAsync(request.ProductId);

            if (existingProduct == null)
            {
                // Handle not found
                return null;
            }

            existingProduct.UpdateDetails(request.NewName, request.NewPrice);

            await _productRepository.UpdateAsync(existingProduct);
            await _mediator.Publish(new ProductUpdated(existingProduct.Id, existingProduct.Name, existingProduct.Price), cancellationToken);

            return existingProduct;
        }
    }
}
