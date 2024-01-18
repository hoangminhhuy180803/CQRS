using Domain.Model;
using MediatR;

namespace API.Application.Queries
{
    public class GetBookIdQuery(Guid Id) : IRequest<Books>;

}
