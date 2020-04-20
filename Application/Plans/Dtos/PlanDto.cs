using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class PlanDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal? DeductionMPR { get; set; }
        public decimal? InductionMPR { get; set; }
        public decimal ActualMPR { get; set; }
        public decimal MinimumScope { get; set; }
        public DateTime Created { get; set; }
        public Guid TeamId { get; set; }
        public TeamDto Team { get; set; }
        public DeductionDto Deduction { get; set; }
        public InductionDto Induction { get; set; }
    }
}
