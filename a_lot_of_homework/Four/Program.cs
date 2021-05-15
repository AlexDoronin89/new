using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random random = new Random();
            int maxNegative = int.MinValue;
            int position = -1;


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 10 + 1);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNegative && numbers[i] < 0)
                {
                    position = i;
                    maxNegative = numbers[i];
                }
            }
            Console.WriteLine();

            Console.WriteLine($"{maxNegative}  {position}");

            Console.ReadKey();
        }
    }
}
