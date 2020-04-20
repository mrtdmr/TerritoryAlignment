using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Markets
{
    public class List
    {
        public class Query : IRequest<List<Market>> { }
        public class Handler : IRequestHandler<Query, List<Market>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Market>> Handle(Query request, CancellationToken cancellationToken)
            {
                var markets = await _context.Markets.ToListAsync();
                return markets;
            }
        }
    }
}
