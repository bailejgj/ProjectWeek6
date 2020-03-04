using System;
using System.Collections.Generic;

namespace QuizApp2
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
        }

        public int QuestionId { get; set; }
        public int? CategoryId { get; set; }
        public string Question { get; set; }
        public int? Difficulty { get; set; }
        public int? Score { get; set; }
        public int Tallowance { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
