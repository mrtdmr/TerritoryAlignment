using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "InductionDetail")]
    public class InductionDetail
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? Market { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? MarketGeographicRatio { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? PhysicianCount { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? PhysicianGeographicRatio { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal? WeightedGeographicRatio { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
        public Guid InductionId { get; set; }
        public virtual Induction Induction { get; set; }
    }
}
