using MediatR;

namespace API.Application.Commands
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
