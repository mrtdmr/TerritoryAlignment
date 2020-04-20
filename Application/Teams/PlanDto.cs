using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Teams
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
    }
}
