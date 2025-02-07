using Exam2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2_try_5
{
    class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            AnswerList = new Answer[4];
        }
        public override string Header => "MCQ Question";

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


            Console.WriteLine("choices of Question : ");
            for (int i = 0; i < 4; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Enter choices Number {i + 1} :");
                AnswerList[i].AnswerText = Console.ReadLine();

            }
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
