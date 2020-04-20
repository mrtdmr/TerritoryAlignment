using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class InductionDetailDto
    {
        public Guid Id { get; set; }
        public decimal? Market { get; set; }
        public decimal? MarketGeographicRatio { get; set; }
        public decimal? PhysicianCount { get; set; }
        public decimal? PhysicianGeographicRatio { get; set; }
        public decimal? WeightedGeographicRatio { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }
    }
}
