using Application.Plans.Dtos;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Plans
{
    public class List
    {        
        public class Query : IRequest<List<PlanDto>> { }
        public class Handler : IRequestHandler<Query, List<PlanDto>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context,IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<PlanDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var plans = await _context.Plans.ToListAsync();
                return _mapper.Map<List<Plan>, List<PlanDto>>(plans);
            }
        }
    }
}
