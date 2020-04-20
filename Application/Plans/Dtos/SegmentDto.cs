using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class SegmentDto
    {
        public Guid Id { get; set; }
        public decimal Rate { get; set; }
        public decimal TargetCount { get; set; }
        public decimal TargetFrequency { get; set; }
        public decimal Visit { get; set; }
    }
}
