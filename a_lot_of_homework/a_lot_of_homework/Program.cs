using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_lot_of_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Посчитать сумму элементов массива
            int sum = 0;
            int[] numbers = new int[5];
            Random random = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100 + 1);
                Console.Write(numbers[i] + " ");
            }
            foreach (var item in numbers)
            {
                sum +=item;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
