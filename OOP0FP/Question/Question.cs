using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP0FP
{
   abstract class Question : ICloneable,IComparable
    {

        public string header;
        public string body;
        public double mark;
        public Answer[] answerList;
        public Answer rightAnswer;

        protected Question(string header, string body, double mark, Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
           
        }

        protected Question()
        {
            Header = "undefined";
            Body = "undefined";
            Mark = 0;
            AnswerList = new Answer[0];
            RightAnswer = new Answer();
        }
        public string Header
        {
            get{ return header; }
            set { header = value; }
        }
        public string Body
        {
            get { return body; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Question cannot be empty");
                else { body = value; }
            }
        }
        public double Mark
        {
            get { return mark; }
            set
            { 
                if(value>0)
                mark=value;
            }
        }
        public Answer[] AnswerList
        {
            get { return answerList; }
            set { answerList=value; }
        }

        public Answer RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer=value; }

        }
        public override string ToString()
        {
            return $"{Header} : {Body} == Mark : {Mark}";
        }

        public abstract object Clone();

        public int CompareTo(object? obj)
        {
            if (obj is Question other)
            {
                return Mark.CompareTo(other.Mark);
            }

            return 1;
        }
    }
}
