using Domain.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.Application.Queries.QueriesHandler
{
    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, IEnumerable<Books>>
    {
        private readonly BookDbContext _dbContext;
        public GetBookQueryHandler(BookDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<IEnumerable<Books>> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Books.ToListAsync(cancellationToken);
        }
    }
}
