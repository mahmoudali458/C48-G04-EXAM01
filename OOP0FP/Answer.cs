using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
    class Answer : ICloneable
    {
        int answerId;
        string answerText;

        public Answer()
        {
            AnswerId = 0;
            AnswerText = null;
        }
        public Answer(int answerId, string answerText)
        {
            this.answerId = answerId;
            this.answerText = answerText;
        }

        public int AnswerId
        {
            get {return answerId;}
            set{ answerId = value;}
        }
        public string  AnswerText 
        { 
            get { return answerText; }
            set { answerText = value; }
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }
    }
}
