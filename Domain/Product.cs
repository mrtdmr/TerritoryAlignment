using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Product")]
    public class Product : BaseModel
    {
        public Guid MarketId { get; set; }
        public virtual Market Market { get; set; }
    }
}
