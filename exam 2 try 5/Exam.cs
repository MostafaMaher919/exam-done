using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal abstract class Exam
    {


        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] listofQuestions { get; set; }

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;

        }



        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();

    }
}
