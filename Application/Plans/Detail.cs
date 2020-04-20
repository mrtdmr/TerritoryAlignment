using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Plans.Dtos;
namespace Application.Plans
{
    public class Detail
    {
        public class Query : IRequest<PlanDto>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, PlanDto>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<PlanDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var plan = await _context.Plans.FindAsync(request.Id);
                return _mapper.Map<Plan, PlanDto>(plan);
            }
        }
    }
}
