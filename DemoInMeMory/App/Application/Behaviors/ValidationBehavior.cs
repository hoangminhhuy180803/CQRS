using Infrastructure.Behaviors;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace App.Application.Behaviors
{
    // Trong App.Application.Behaviors
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (request is IValidatableObject validatableObject)
            {
                var validationResults = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(validatableObject, new ValidationContext(validatableObject), validationResults, true);

                if (!isValid)
                {
                    throw new ValidationException(validationResults);
                }
            }

            return await next();
        }

        
    }

}
