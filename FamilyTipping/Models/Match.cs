using System.Collections.Generic;

namespace FamilyTipping.Models
{
    public class Match
    {
        public int Id { get; set; }
        public List<Team> Teams { get; set; }
    }
}
