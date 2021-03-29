using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the room: ");
            string length = Console.ReadLine();
            decimal lengthNum = decimal.Parse(length);

            Console.Write("Enter the width of the room: ");
            string width = Console.ReadLine();
            decimal widthNum = decimal.Parse(width);

            Console.Write("Enter the overage percent: ");
            string overage = Console.ReadLine();
            decimal overageInt = int.Parse(overage);
            decimal overagePercent = overageInt / 100;

            decimal area = lengthNum * widthNum;
            decimal overageAmount = area * overagePercent;
            decimal total = area + overageAmount;

            Console.Write($"The total area, including overage, is: {total}");



        }
    }
}
