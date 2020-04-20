using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Teams
{
    public class List
    {
        public class Query : IRequest<List<TeamDto>> { }
        public class Handler : IRequestHandler<Query, List<TeamDto>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<TeamDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var teams = await _context.Teams.ToListAsync();
                return _mapper.Map<List<Team>,List<TeamDto>>(teams);
            }
        }
    }
}
