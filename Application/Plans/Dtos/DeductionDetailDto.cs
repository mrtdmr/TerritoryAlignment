using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class DeductionDetailDto
    {
        public Guid Id { get; set; }
        public decimal PhysicianUniverse { get; set; }
        public decimal PhysicianUniverseCovered { get; set; }
        public decimal Scope { get; set; }
        public decimal ScopeCount { get; set; }
        public Guid DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }
        public ICollection<SegmentDto> Segments { get; set; }
    }
}
