using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public partial class Categories
    {
        public Categories()
        {
            Leaderboard = new HashSet<Leaderboard>();
            Questions = new HashSet<Questions>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? NumberofQuestions { get; set; }

        public virtual ICollection<Leaderboard> Leaderboard { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
}
