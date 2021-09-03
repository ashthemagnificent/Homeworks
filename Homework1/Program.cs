using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //int sum = (num1 * (num1 + 1)) / 2 - (num2 * (num2 + 1)) / 2;

            //int summ = Math.Abs(sum);
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                sum += num1 + i++;

            }
            Console.Clear();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
