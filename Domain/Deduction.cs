using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Deduction")]
    public class Deduction
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? AnnualWorkingDay { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? MonthlyWorkingDay { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? DailyVisit { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? MonthlyVisitCapacity { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? MonthlyTargetVisitFrequency { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? MonthlyTargetMPR { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? TargetedTotalPhysician { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? TargetedTotalVisit { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? AverageFrequency { get; set; }
        public Guid PlanId { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual ICollection<DeductionDetail> DeductionDetails { get; set; }
    }
}
