using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = false;
            int number = 0;
            int[] numbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10 + 1);
                Console.Write(numbers[i] + " ");
                
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                number=numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (number== numbers[j] && i!=j)
                    {
                        isWork = true;
                    }
                }
                if (!isWork)
                {
                    Console.WriteLine(number + " ");
                }
            }
            Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}
