using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class FinalExam : Exam
    {
        public FinalExam() : base()
        {
        }
        public FinalExam(double time, int numOfQuestions, Question[] questions) : base(time, numOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            double grade=0;
            Console.WriteLine("==FINAL EXAM==");
            Console.WriteLine($"Time : {Time}");
            Console.WriteLine($"Number of questions is : {NumOfQuestions}");
            for(int i = 1; i <= Questions.Length; i++)
            {
                Question Question =Questions[i - 1];
                Console.WriteLine($"Question {i} : ");
                Console.WriteLine($"{Question.Header}");
                Console.WriteLine($"{Question.Body}");

                Console.WriteLine();
                for(int j = 1; j <= Question.AnswerList.Length; j++)
                {
                    Console.WriteLine($"{Question.AnswerList[j-1]}");
                }

                Console.WriteLine("your answer : ");
                int UserAns;
                int.TryParse(Console.ReadLine(), out UserAns);

                Answer SelectedAns = Question.AnswerList[UserAns-1];
                if (SelectedAns.AnswerId == Question.RightAnswer.AnswerId)
                {
                    grade += Question.Mark;
                }
               
            }
            Console.WriteLine("==Final Result ==");
            double TotalMark=0;
            foreach (Question Question in Questions)
            {
                TotalMark += Question.Mark;
            }
            Console.WriteLine($"your total marks : {TotalMark}/{grade}");
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }
    }
}
