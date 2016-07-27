using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemporaryVariables.Models
{
    public class Team
    {
        public List<Member> teamMembers { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }
}