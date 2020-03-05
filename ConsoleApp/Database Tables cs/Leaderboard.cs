using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public partial class Leaderboard
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int? Score { get; set; }
        public int? CategoryId { get; set; }

        public virtual Categories Category { get; set; }
    }
}
