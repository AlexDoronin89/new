using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            // В массиве случайных целых чисел поменять
            // местами минимальныйи максимальный элементы.
            int[] numbers = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100 + 1);
                Console.Write(numbers[i] + " ");
                if(numbers[i] > max)
                {
                    max=i;
                }
                if (numbers[i] < min)
                {
                    min =i;
                }
                
            }
            int a = numbers[min];
            numbers[min] = numbers[max];
            numbers[max] = a;
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
