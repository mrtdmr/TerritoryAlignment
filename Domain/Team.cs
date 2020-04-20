using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Team")]
    public class Team : BaseModel
    {
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
