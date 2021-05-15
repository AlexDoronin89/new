using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozitive = 0;
            double sum = 0;
            int[] numbers = new int[5];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 10 + 1);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 0)
                {
                    pozitive++;
                    sum += numbers[i];
                }
            }
            sum = sum / pozitive;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
