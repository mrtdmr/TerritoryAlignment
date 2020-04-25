using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
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
            public decimal? DeductionMPR { get; set; }
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
                plan.DeductionMPR = request.DeductionMPR;
                if (plan.Deduction != null)
                    _context.Deductions.Remove(plan.Deduction);
                if(plan.Induction!=null)
                    _context.Inductions.Remove(plan.Induction);

                var deduction = new Deduction { Id = new Guid(), PlanId = plan.Id, AnnualWorkingDay = request.Deduction.AnnualWorkingDay, AverageFrequency = request.Deduction.AverageFrequency, DailyVisit = request.Deduction.DailyVisit, MonthlyTargetMPR = request.Deduction.MonthlyTargetMPR, MonthlyTargetVisitFrequency = request.Deduction.MonthlyTargetVisitFrequency, MonthlyVisitCapacity = request.Deduction.MonthlyVisitCapacity, MonthlyWorkingDay = request.Deduction.MonthlyWorkingDay, TargetedTotalPhysician = request.Deduction.TargetedTotalPhysician, TargetedTotalVisit = request.Deduction.TargetedTotalVisit };
                _context.Deductions.Add(deduction);
                foreach (var dd in request.Deduction.DeductionDetails)
                {
                    var deductionDetail = new DeductionDetail { Id = new Guid(), DeductionId = deduction.Id, DepartmentId = dd.DepartmentId, PhysicianUniverse = dd.PhysicianUniverse, PhysicianUniverseCovered = dd.PhysicianUniverseCovered, Scope = dd.Scope, ScopeCount = dd.ScopeCount };
                    _context.DeductionDetails.Add(deductionDetail);
                    foreach (var s in dd.Segments)
                    {
                        var segment = new Segment { Id = new Guid(), DeductionDetailId = deductionDetail.Id, Rate = s.Rate, TargetCount = s.TargetCount, TargetFrequency = s.TargetFrequency, Visit = s.Visit };
                        _context.Segments.Add(segment);
                    }
                }
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                    return Unit.Value;
                throw new Exception("Hata oluştu.");
            }
        }
    }
}
