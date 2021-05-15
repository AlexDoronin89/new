using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {

        static void Main(string[] args)
        {
            //2. В массиве, содержащем положительные и отрицательные целые числа,
            //вычислить сумму четных положительных элементов.
            int[] numbers = new int[5];
            int sum = 0;
            Random random = new Random();
            for (int i = 0; i <  numbers.Length; i++)
            {
                numbers[i] = random.Next(-5, 10 + 1);
                Console.Write(numbers[i] + " ");
                if (numbers[i] > 0 && numbers[i] % 2 ==0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
