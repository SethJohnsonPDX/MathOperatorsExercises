using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            Console.Clear();
            int inputInt = Convert.ToInt32(input);
            Console.WriteLine(inputInt * 50);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter another number: ");
            string input1 = Console.ReadLine();
            Console.Clear();
            int inputInt1 = Convert.ToInt32(input1);
            Console.WriteLine(inputInt1 + 25);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter another number: ");
            string input2 = Console.ReadLine();
            Console.Clear();
            double inputInt2 = Convert.ToDouble(input2);
            Console.WriteLine(inputInt2 / 12.5);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter another number: ");
            string input3 = Console.ReadLine();
            Console.Clear();
            int inputInt3 = Convert.ToInt32(input3);
            bool isGreater = inputInt3 > 50;
            Console.WriteLine(isGreater);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter another number: ");
            string input4 = Console.ReadLine();
            Console.Clear();
            int inputInt4 = Convert.ToInt32(input4);
            Console.WriteLine(inputInt4 % 7);
            Console.ReadLine();
            Console.Clear();


        }
    }
}
