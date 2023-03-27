
using System;
using System.Globalization;

namespace Percents
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел три числа: исходную сумму, процентную ставку (в процентах) и срок вклада в месяцах");
            Console.WriteLine(Calculate(Console.ReadLine()));
        }
        public static double Calculate(string userInput)
        {
            var contribution = userInput.Split();
            var deposit = double.Parse(contribution[0], CultureInfo.InvariantCulture);
            var rate = double.Parse(contribution[1], CultureInfo.InvariantCulture);
            var period = double.Parse(contribution[2]);
            return deposit * Math.Pow(1+rate/100/12, period);
        }
    }
}