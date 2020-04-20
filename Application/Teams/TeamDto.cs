using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Teams
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<PlanDto> Plans { get; set; }
    }
}
