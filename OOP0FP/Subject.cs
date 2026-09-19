using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class Subject
    {
        int SubjectId;
        string SubjectName;
        Exam exam;

        public Subject()
        {
            SubjectId = 0;
            SubjectName = "Unknown";
            Exam = null;
        }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            exam = null;
        }

        public int SubjectId1 { get => SubjectId; set => SubjectId = value; }
        public string SubjectName1 { get => SubjectName; set => SubjectName = value; }
        public Exam Exam { get => exam; set => exam = value; }

        public void CreatExam()
        {
            Console.WriteLine("enter exame type : (1 for FINAL / 2 fo Practical) ");
            int examType;
            int.TryParse(Console.ReadLine(), out examType);
            Console.WriteLine("enter the duration of the exam :");
            double time;
            double.TryParse(Console.ReadLine(), out time);
            Console.WriteLine("enter number of questions :");
            int numberQ;
            int.TryParse(Console.ReadLine(), out numberQ);

            Question[] Questions = new Question[numberQ];
            for(int i=1;i<=numberQ;i++)
            {
                Console.WriteLine($"===question {i}===");
                if(examType==1)
                {
                    //final has mcq/t.f
                    Console.WriteLine("enter type of quetion :(1 for T/F and 2 for MCQ) ");
                    int Qtype;
                    int.TryParse(Console.ReadLine(), out Qtype);
                   Questions[i - 1]= CreatQuestion(Qtype);

                }
                else
                {
                    //prac only mcq
                   Questions[i-1]= CreatQuestion(2);
                }

            }
            if (examType == 1)
            {
                Exam = new FinalExam(time, numberQ, Questions);

            }
            else
            {
                Exam = new PracticalExam(time, numberQ, Questions);
            }

        }
        
       
        private Question CreatQuestion(int QuestionType)
        {
            Console.WriteLine("Enter Question Header : ");
            string header = Console.ReadLine();
            Console.WriteLine("enter the body : ");
            string body = Console.ReadLine();
            Console.WriteLine("enter Question mark : ");
            int mark;
            int.TryParse(Console.ReadLine(), out mark);

            if(QuestionType==1)
            {
                //T/F
                Answer[] answers =
                {
                    new Answer(1,"TRUE"),
                    new Answer(2,"FALSE")
                };

                Console.WriteLine("Choose the right answer :( 1.TRUE / 2.FALSE ) ");
                //int answerID;
                //int.TryParse(Console.ReadLine(), out answerID);
                //Console.WriteLine("Right answer is : ");
                int rightAnswer;
                int.TryParse(Console.ReadLine(), out rightAnswer);

                return new TrueFalseQ(header, body, mark, answers, answers[rightAnswer - 1]);
            }
            else
            {
                //MCQ


                Answer[] answers = new Answer[4];
                for(int i=1;i<=4;i++)
                {
                    Console.WriteLine($"enter answer {i} : ");
                    string answerText = Console.ReadLine();
                    answers[i-1] = new Answer(i, answerText);

                }

                Console.WriteLine("Choose Right Answer:");

                for (int i = 0; i < answers.Length; i++)
                {
                    Console.WriteLine(answers[i]);
                }
                Console.WriteLine("the right answer is : ");
                int rightAnswer;
                int.TryParse(Console.ReadLine(), out rightAnswer);
              
            
                return new MCQ(header, body, mark, answers, answers[rightAnswer - 1]);
            }
        }
        
    }
}
