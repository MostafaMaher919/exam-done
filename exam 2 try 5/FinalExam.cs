using exam_2_try_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int NumberOfQuestions) : base(time, NumberOfQuestions)
        {

        }


        public override void CreateListOfQuestions()
        {
            listofQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < listofQuestions.Length; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("Enter Type of Questions [1 => MCQ || 2=> True & False ]");


                }
                while (!int.TryParse(Console.ReadLine(), out choice) && choice < 1 || choice > 2);
                if (choice == 1)
                {
                    listofQuestions[i] = new MCQQuestion();
                    listofQuestions[i].AddQuestion();

                }
                else
                {
                    listofQuestions[i] = new TrueFalseQuestion();
                    listofQuestions[i].AddQuestion();
                }

            }
        }

        public override void ShowExam()
        {
            foreach (var questions in listofQuestions)
            {
                Console.WriteLine(questions);
                for (int i = 0; i < questions.AnswerList.Length; i++)
                {
                    Console.WriteLine(questions.AnswerList[i]);
                }
                Console.WriteLine("-----------------------------------------");
                int UserAnswerId;
                do
                {
                    Console.WriteLine("Enter Number of your Answer : ");

                }
                while (!int.TryParse(Console.ReadLine(), out UserAnswerId));
                questions.UserAnswer.AnswerId = UserAnswerId;
                questions.UserAnswer.AnswerText = questions.AnswerList[UserAnswerId - 1].AnswerText;
                Console.WriteLine("-------------------------------------------------------");
                int totalMark = 0, Grade = 0;
                for (int i = 0; i < listofQuestions.Length; i++)
                {
                    totalMark += listofQuestions[i].Mark;
                    if (listofQuestions[i].RightAnswer.AnswerId == listofQuestions[i].UserAnswer.AnswerId)
                    {
                        Grade += listofQuestions[i].Mark;

                    }
                    //Console.Clear();
                    Console.WriteLine($"Questions ({i + 1}) : {listofQuestions[i].Body}");
                    Console.WriteLine($"Your Answer : {listofQuestions[i].UserAnswer.AnswerText}");
                    Console.WriteLine($"Right Answer ({i + 1}) : {listofQuestions[i].RightAnswer.AnswerText}");

                }

                Console.WriteLine($"your Grade is {Grade} from {totalMark}");
            }
        }
    }
}
