using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }



        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;

        }

        public void CreateExam()
        {
            int time;
            do
            {
                Console.WriteLine("enter time of exam :");


            }
            while (!int.TryParse(Console.ReadLine(), out time));

            int questions;
            do
            {
                Console.WriteLine("enter number of questions : ");
            }
            while (!int.TryParse(Console.ReadLine(), out questions));

            int examType;
            do
            {
                Console.WriteLine("enter type of exam [1] for practical AND [2] for final : ");
            }
            while (!int.TryParse(Console.ReadLine(), out examType));

            if (examType == 1)
            {
                Exam = new PracticalExam(time, questions);

            }
            else
            {
                Exam = new FinalExam(time, questions);
            }
            Console.Clear();
            Exam.CreateListOfQuestions();

        }
    }
}
