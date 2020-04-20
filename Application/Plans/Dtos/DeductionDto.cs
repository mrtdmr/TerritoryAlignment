using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Plans.Dtos
{
    public class DeductionDto
    {
        public Guid Id { get; set; }
        public decimal AnnualWorkingDay { get; set; }
        public decimal MonthlyWorkingDay { get; set; }
        public decimal DailyVisit { get; set; }
        public decimal MonthlyVisitCapacity { get; set; }
        public decimal MonthlyTargetVisitFrequency { get; set; }
        public decimal MonthlyTargetMPR { get; set; }
        public decimal TargetedTotalPhysician { get; set; }
        public decimal TargetedTotalVisit { get; set; }
        public decimal AverageFrequency { get; set; }
        public ICollection<DeductionDetailDto> DeductionDetails { get; set; }
    }
}
