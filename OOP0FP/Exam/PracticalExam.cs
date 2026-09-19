using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class PracticalExam : Exam
    {
        public PracticalExam()
        {
            Time = 0;
            NumOfQuestions = 0;
            Questions = null;
        }

        public PracticalExam(double time, int numOfQuestions, Question[] questions) : base(time, numOfQuestions, questions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = questions;
        }

        public override void ShowExam()
        {
            double grade = 0;
            Console.WriteLine("== Practical Exam ==");
            for(int i = 1; i <= Questions.Length; i++)
            {
                Question Question = Questions[i - 1];
                Console.WriteLine($"question {i}");
                Console.WriteLine($"{Question.Header}");
                Console.WriteLine($"{Question.Body}");

                for(int j=1; j <= Question.AnswerList.Length; j++)
                {
                    Console.WriteLine($"{Question.AnswerList[j-1]}");
                    
                }
                Console.WriteLine();
                Console.WriteLine($"correct answre : {Question.RightAnswer}  ");
                Console.WriteLine("========================");


            }
        }
    }
}
