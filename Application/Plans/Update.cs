using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Plans
{
    public class Update
    {
        public class Commmand : IRequest
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public decimal? ActualMPR { get; set; }
            public decimal? MinimumScope { get; set; }
            public Guid TeamId { get; set; }
            public Team Team { get; set; }
            public Deduction Deduction { get; set; }
        }
        public class Handler : IRequestHandler<Commmand>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Commmand request, CancellationToken cancellationToken)
            {
                var plan = await _context.Plans.FindAsync(request.Id);
                if (plan == null)
                    throw new Exception("Plan bulunamadı.");
                plan.Name = request.Name ?? plan.Name;
                plan.ActualMPR = request.ActualMPR ?? plan.ActualMPR;
                plan.MinimumScope = request.MinimumScope ?? plan.MinimumScope;
                plan.TeamId = request.TeamId;
                plan.Deduction.AnnualWorkingDay=request.Deduction.AnnualWorkingDay?? request.Deduction.AnnualWorkingDay;
                plan.Deduction.MonthlyWorkingDay = request.Deduction.MonthlyWorkingDay ?? request.Deduction.MonthlyWorkingDay;
                plan.Deduction.DailyVisit = request.Deduction.DailyVisit ?? request.Deduction.DailyVisit;
                plan.Deduction.MonthlyVisitCapacity = request.Deduction.MonthlyVisitCapacity ?? request.Deduction.MonthlyVisitCapacity;
                _context.Plans.Update(plan);
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                    return Unit.Value;
                throw new Exception("Hata oluştu.");
            }
        }
    }
}
