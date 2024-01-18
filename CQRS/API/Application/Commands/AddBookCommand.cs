using Domain.Model;
using MediatR;

namespace API.Application.Commands
{
    public record AddBookCommand(Books books) : IRequest<Books>;
 
}
