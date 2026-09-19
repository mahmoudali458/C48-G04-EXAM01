using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class MCQ : Question
    {
        public MCQ(): base ()
        {
        }

        public MCQ(string header, string body, double mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override object Clone()
        {
            Answer[] clonedAnswers = new Answer[AnswerList.Length];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                clonedAnswers[i] = (Answer)AnswerList[i].Clone();
            }
            Answer clonedRightAnswer = (Answer)RightAnswer.Clone();

            return new MCQ(Header, Body, Mark, clonedAnswers, clonedRightAnswer);
        }
    }
}
