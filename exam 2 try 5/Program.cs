using Exam2;
using System.Diagnostics;

namespace exam_2_try_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject sup1 = new(1, "Math");
            sup1.CreateExam();

            Console.WriteLine("DO you want to start exam now ?(Y | N) : ");
            char Choice = char.Parse(Console.ReadLine());
            if (Choice == 'Y' || Choice == 'y')
            {
                Console.Clear();
                Stopwatch sw = new();
                sw.Start();
                sup1.Exam.ShowExam();
                Console.WriteLine($"\n taken time = {sw.Elapsed}");

            }
            else
            {
                Console.WriteLine("Thank You ! ");
            }



        }
    }
}
