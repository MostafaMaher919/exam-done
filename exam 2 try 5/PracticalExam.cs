using exam_2_try_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int NumberOfQuestions) : base(time, NumberOfQuestions)
        {

        }


        public override void CreateListOfQuestions()
        {
            listofQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < listofQuestions.Length; i++)
            {
                listofQuestions[i] = new MCQQuestion();
                listofQuestions[i].AddQuestion();
                Console.Clear();

            }


        }

        public override void ShowExam()
        {

            foreach (var question in listofQuestions)
            {
                Console.WriteLine(question);
                for (int i = 0; i < question.AnswerList.Length; i++)
                {
                    Console.WriteLine(question.AnswerList[i]);

                }
                Console.WriteLine("------------------------------------------");
                int UserAnserId;
                do
                {
                    Console.WriteLine("Enter Id of your anser : ");
                }
                while (!int.TryParse(Console.ReadLine(), out UserAnserId));
                question.UserAnswer.AnswerId = UserAnserId;
                question.UserAnswer.AnswerText = question.AnswerList[UserAnserId - 1].AnswerText;
                Console.WriteLine("=================================");

                for (int i = 0; i < listofQuestions.Length; i++)
                {
                    //Console.Clear();
                    Console.WriteLine($"Questions ({i + 1}) : {listofQuestions[i].Body}");
                    Console.WriteLine($"Right Answer : {listofQuestions[i].RightAnswer.AnswerText}");
                    Console.WriteLine("---------------------------------------------------");


                }

            }




        }
    }
}
