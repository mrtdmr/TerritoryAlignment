using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Induction")]
    public class Induction
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? GeographicRatio { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? PhysicianRatio { get; set; }
        public Guid PlanId { get; set; }
        public virtual Plan Plan { get; set; }
        public virtual ICollection<InductionDetail> InductionDetails { get; set; }
    }
}
