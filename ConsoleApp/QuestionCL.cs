using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class QuestionCL
    {
        public string _question;
        public int currentQ = 0;
        private List<Questions> qs;

        //Querying the questions from database to get the stored question
        public QuestionCL()
        {
            using (var db = new week6ProjectContext())
            {
                // get the list store in qs
                //          var qInList = qList[currentQ];
                //         qInList.Answers.FirstOrDefault().
                qs =
                    (from q in db.Questions.Include(a => a.Answers)
                    select q).ToList();
            }
        }
        //When called the question number increases by one and returns the corresponding question
        public string ChangeQuestion()
        {
            if (currentQ < 30)
            {
                currentQ++;
            }
            return qs[currentQ].ToString();
        }
        //public string ChangeAnswer()
        //{
        //    if (currentQ <30)
        //    {
        //        return
        //    }
        //}
    }
}