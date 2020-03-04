using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QuizApp2
{
    class QuizCode
    {
        public int _time;
        public string _name;
        public int _scoreCount=0;
        public int _points;
        public string Timer()
        {
            int i = _time;
            while(i>0)
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
    }
}
