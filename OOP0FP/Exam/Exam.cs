using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    abstract class Exam
    {

        double time;
        int numOfQuestions;
       public Question[] questions;

        protected Exam()
        {
            Time = 0;
            NumOfQuestions = 0;
            Questions = new Question[0];

        }   
        protected Exam (double time, int numOfQuestions, Question[] questions)   
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = questions;
           
        }

        public double Time 
        { 
            get => time;
            set
            {
                if (value>=30&&value<=180)
                    time = value;
                else { Console.WriteLine("invalid time!!"); }
            }
        }
        public int NumOfQuestions
        {
            get => numOfQuestions;
            set
            {
                if (value >= 5)
                 numOfQuestions = value;
            }
        }
        public Question[] Questions { get => questions; set => questions = value; }

        public abstract void ShowExam();
       

       

    }
}
