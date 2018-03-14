using System;
using System.Collections.Generic;

namespace FamilyTipping.Models
{
    public class Round
    {
        public int Id { get; set; }
        public List<Match> Matches { get; set; }
        public DateTime LockoutDate { get; set; }
    }
}
