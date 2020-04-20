using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class InductionDto
    {
        public Guid Id { get; set; }
        public decimal? GeographicRatio { get; set; }
        public decimal? PhysicianRatio { get; set; }
        public ICollection<InductionDetailDto> InductionDetails { get; set; }
    }
}
