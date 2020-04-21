using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Segment")]
    public class Segment
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Rate { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? TargetCount { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal TargetFrequency { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? Visit { get; set; }
        public Guid DeductionDetailId { get; set; }
        public virtual DeductionDetail DeductionDetail { get; set; }
    }
}
