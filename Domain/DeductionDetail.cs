using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "DeductionDetail")]
    public class DeductionDetail
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? PhysicianUniverse { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? PhysicianUniverseCovered { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? Scope { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? ScopeCount { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Guid DeductionId { get; set; }
        public virtual Deduction Deduction { get; set; }
        public virtual ICollection<Segment> Segments { get; set; }
    }
}
