using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal abstract class Question
    {


        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }


        protected Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public override string ToString()
        {
            return $"{Header} \t Mark: {Mark} \n " + "-----------------------------" + $"\n {Body} \n";
        }

        public abstract void AddQuestion();




    }
}
