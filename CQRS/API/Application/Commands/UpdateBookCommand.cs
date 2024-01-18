using Domain.Model;
using MediatR;

namespace API.Application.Commands
{
    public class UpdateBookCommand : IRequest<Books>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Authors { get; set; }
    }
}
