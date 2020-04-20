using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Plan")]
    public class Plan : BaseModel
    {
        [Column(TypeName = "decimal(12,2)")]
        public decimal? DeductionMPR { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? InductionMPR { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ActualMPR { get; set; }
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal MinimumScope { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public virtual Deduction Deduction { get; set; }
        public virtual Induction Induction { get; set; }
        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
