using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "DepartmentCity")]
    public class DepartmentCity
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal PhysicianCount { get; set; }
        public bool Active { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}
