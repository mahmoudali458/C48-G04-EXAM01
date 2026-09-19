using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class TrueFalseQ : Question
    {
        public TrueFalseQ() : base()
        {
        }

        public TrueFalseQ(string header, string body, double mark, Answer[] answerList, Answer rightAnswer) :
            base(header, body, mark, answerList, rightAnswer)
        {
        }
        public override object Clone()
        {
            Answer[] cloneAnswers = new Answer[AnswerList.Length];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                cloneAnswers[i] = (Answer)AnswerList[i].Clone();
            }
            Answer clonedRightAnswer = (Answer)RightAnswer.Clone();

            return new TrueFalseQ(Header, Body, Mark, cloneAnswers, clonedRightAnswer);
        }
    }
}
