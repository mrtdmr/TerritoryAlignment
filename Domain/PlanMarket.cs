using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "PlanMarket")]
    public class PlanMarket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public virtual Plan Plan { get; set; }
        public Guid MarketId { get; set; }
        public virtual Market Market { get; set; }
    }
}
