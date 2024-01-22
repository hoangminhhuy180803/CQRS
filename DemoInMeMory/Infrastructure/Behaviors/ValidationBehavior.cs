using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (request is IValidatableObject validatable)
            {
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateObject(validatable, new ValidationContext(validatable), validationResults, true);

                if (validationResults.Any())
                {
                    // Handle validation errors
                    throw new ValidationException(ValidationBehavior);
                }
            }

            return await next();
        }

      
    }
}
