using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how much bread you would like (1, 2 or 3): ");
            int OrderAmount = Convert.ToInt32(Console.ReadLine());

            switch (OrderAmount)
            {
                case 1:
                    Console.WriteLine("1 loaf of bread has been added to your basket");
                    break;
                case 2:
                    Console.WriteLine("2 loafs of bread have been added to your basket");
                    break;
                case 3:
                    Console.WriteLine("Error: Only 2 loafs can be given to each customer");
                    break;
            }

        }
    }
}
