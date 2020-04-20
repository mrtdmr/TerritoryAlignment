using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "MarketCity")]
    public class MarketCity
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Amount { get; set; }
        public bool Active { get; set; }
        public Guid MarketId { get; set; }
        public virtual Market Market { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}
