using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public partial class Answers
    {
        public int AnswerId { get; set; }
        public int? QuestionId { get; set; }
        public string Answer { get; set; }
        public string NonAnswer1 { get; set; }
        public string NonAnswer2 { get; set; }
        public string NonAnswer3 { get; set; }

        public virtual Questions Question { get; set; }
    }
}
