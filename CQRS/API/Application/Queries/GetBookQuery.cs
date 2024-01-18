using Domain.Model;
using MediatR;

namespace API.Application.Queries
{
    public class GetBookQuery : IRequest<IEnumerable<Books>>;

}
