using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class TrueFalseQuestion : Question
    {


        public override string Header => "True | Talse Question ";

        public TrueFalseQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");
        }

        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Enter body of Question :");
            Body = Console.ReadLine();

            int mark;
            do
            {
                Console.WriteLine("Enter Mark Of Question");

            }
            while (!int.TryParse(Console.ReadLine(), out mark));
            Mark = mark;



            int rightAnswerid;
            do
            {
                Console.WriteLine("Enter Id of Right Answer :");
            }
            while (!int.TryParse(Console.ReadLine(), out rightAnswerid));
            RightAnswer.AnswerId = rightAnswerid;
            RightAnswer.AnswerText = AnswerList[rightAnswerid - 1].AnswerText;

            Console.Clear();
        }


    }
}
