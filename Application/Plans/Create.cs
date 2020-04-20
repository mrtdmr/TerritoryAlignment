using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Plans
{
    public class Create
    {
        public class Command : IRequest
        {
            public string Name { get; set; }
            public decimal ActualMPR { get; set; }
            public decimal MinimumScope { get; set; }
            public Guid TeamId { get; set; }
            public ICollection<Market> Markets { get; set; }
            public ICollection<City> Cities { get; set; }
            public ICollection<Department> Departments { get; set; }
            public ICollection<Segment> Segments { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var plan = new Plan { Id = new Guid(), Name = request.Name, ActualMPR = request.ActualMPR, MinimumScope = request.MinimumScope, TeamId = request.TeamId, Active = true, Created = DateTime.Now, Deduction = new Deduction { Id = new Guid(), DeductionDetails = new List<DeductionDetail>() }, Induction = new Induction { Id = new Guid(), InductionDetails = new List<InductionDetail>() } };


                var marketTotal = (from mc in _context.MarketCities.ToArray()
                                   join c in request.Cities on mc.CityId equals c.Id
                                   join m in request.Markets on mc.MarketId equals m.Id
                                   select mc).Sum(mc => mc.Amount);
                var physicianTotal = (from dc in _context.DepartmentCities.ToArray() join c in request.Cities on dc.CityId equals c.Id join d in request.Departments on dc.DepartmentId equals d.Id select dc).Sum(dc => dc.PhysicianCount);
                foreach (var city in request.Cities)
                {
                    var marketCityTotal = (from mc in _context.MarketCities.ToArray()
                                           join c in request.Cities on mc.CityId equals c.Id
                                           join m in request.Markets on mc.MarketId equals m.Id
                                           where mc.CityId == city.Id
                                           select mc).Sum(mc => mc.Amount);

                    var physicianCityTotal = (from dc in _context.DepartmentCities.ToArray()
                                              join c in request.Cities on dc.CityId equals c.Id
                                              join d in request.Departments on dc.DepartmentId equals d.Id
                                              where dc.CityId == city.Id
                                              select dc).Sum(dc => dc.PhysicianCount);

                    var inductionDetail = new InductionDetail { Id = new Guid(), Market = marketCityTotal, MarketGeographicRatio = (marketCityTotal / marketTotal) * 100, PhysicianCount = physicianCityTotal, PhysicianGeographicRatio = (physicianCityTotal / physicianTotal) * 100, CityId = city.Id };
                    plan.Induction.InductionDetails.Add(inductionDetail);
                }
                foreach (var department in request.Departments)
                {
                    var physicianUniverse = (from dc in _context.DepartmentCities.ToArray() join c in request.Cities on dc.CityId equals c.Id where dc.DepartmentId == department.Id select dc).Sum(dc => dc.PhysicianCount);
                    var deductionDetail = new DeductionDetail { Id = new Guid(), DepartmentId = department.Id, PhysicianUniverse = physicianUniverse, PhysicianUniverseCovered = 100 };
                    foreach (var segment in request.Segments)
                    {
                        deductionDetail.Segments.Add(segment);
                    }
                    plan.Deduction.DeductionDetails.Add(deductionDetail);
                }
                await _context.Plans.AddAsync(plan);
                foreach (var market in request.Markets)
                {
                    await _context.PlanMarkets.AddAsync(new PlanMarket { PlanId = plan.Id, MarketId = market.Id });
                }
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                    return Unit.Value;
                throw new Exception("Hata oluştu.");
            }
        }
    }
}
