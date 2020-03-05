using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        public string _question;
        public static void Main(string[] args)
        {
        }
        //    public string Qquery()
        //    { 
        //        using (var db = new week6ProjectContext())
        //        {
        //            var qQuery =
        //                from Question in db.Questions
        //                select Question;
        //            foreach (var q in qQuery)
        //            {
        //                _question = q;
        //            }
        //        }
        //        return _question;
        //    }
    }
}
//        //public int _time;
//        //public int _scoreCount = 0;
//        //public int _points;
//        //public string Timer()
//        //{
//        //    int i = _time;
//        //    while (i > 0)
//        //    {
//        //        Thread.Sleep(1000);
//        //        i--;
//        //    }
//        //    return "Time's Up";
//        //}
//        //public int Score()
//        //{
//        //    _scoreCount += _points;
//        //    return _scoreCount;
//        //}
//    }
//    }
//}
