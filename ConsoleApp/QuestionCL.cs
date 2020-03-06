using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    public class QuestionCL
    {
        private int _score;
        private string _question;
        private int _currentQ = -1;
        private string _answer;
        private string _nonanswer1;
        private string _nonanswer2;
        private string _nonanswer3;
        private List<Questions> qs;
        public int currentQ
        {
            get { return _currentQ; }
            set { 
                if (value >=0 || value <= 30)
                { _currentQ = value; }
                }
        }
        public int Score
        {
            get { return _score; }
            set {
                if (value <= 29 || value > -1)
                { _score = value; }
            }
        }

        //Querying the questions from database to get the stored question
        public QuestionCL()
        {
            using (var db = new week6ProjectContext())
            {
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
                //currentQ++;
                _question = qs[currentQ].ToString();
                return qs[currentQ].ToString();
            }
            //Return blank if the question is above 30 to prevent errors
            return "";
        }
        public string ChangeAnswer()
        {
            if (currentQ < 30)
            {
                return qs[currentQ].Answers.FirstOrDefault().Answer;
            }
            _answer = qs[currentQ].Answers.FirstOrDefault().Answer;
            return "";
        }
        public string ChangeNonAnswer1()
        {
            if (currentQ < 30)
            {
                return qs[currentQ].Answers.FirstOrDefault().NonAnswer1;
            }
            _nonanswer1 = qs[currentQ].Answers.FirstOrDefault().Answer;
            return "";
        }
        public string ChangeNonAnswer2()
        {
            if (currentQ < 30)
            {
                return qs[currentQ].Answers.FirstOrDefault().NonAnswer2;
            }
            _nonanswer2 = qs[currentQ].Answers.FirstOrDefault().Answer;
            return "";
        }
        public string ChangeNonAnswer3()
        {
            if (currentQ < 30)
            {
                return qs[currentQ].Answers.FirstOrDefault().NonAnswer3;
            }
            _nonanswer3 = qs[currentQ].Answers.FirstOrDefault().Answer;
            return "";
        }
        public int ButtonMover()
        {
            Random rnd = new Random();
            int ButtonMove = rnd.Next(1, 5);
            return ButtonMove;
        }
        static void Main(string[] args)
        { }
    }
}