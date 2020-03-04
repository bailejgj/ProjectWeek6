using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace QuizApp2
{
    class QuizCode
    {
        public int _time;
        public int _scoreCount = 0;
        public int _points;
        public string Timer()
        {
            int i = _time;
            while (i > 0)
            {
                Thread.Sleep(1000);
                i--;
            }
            return "Time's Up";
        }
        public int Score()
        {
            _scoreCount += _points;
            return _scoreCount;
        }
        public void Question()
        {
            List<string> Questions = new List<string>();

        }
    }
    class Queries
    {
        public static void Main(string[] args)
        {
            using (var db = new week6ProjectContext())
            {
                var qQuery =
                    from Question in db.Questions
                    select Question;
                foreach (var Question in qQuery)
                {
                    Console.WriteLine(Question);
                }
            }
        }


    }
}
