using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10 + 1);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            int a = numbers[0];
            numbers[0] = numbers[4];
            numbers[4] = a;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            int next;
            int b = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                next = numbers[i + 1];
                numbers[i + 1] =b;
                b = next;
            }
            numbers[0]=b;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
