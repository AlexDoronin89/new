using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double sum=0;
            int[] numbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10 + 1);
                Console.Write(numbers[i] + " ");
                
            }
            foreach (var item in numbers)
            {
                sum += item ;
            }
            sum = sum / 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < sum)
                {
                 
                    number++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("кол-во эл" + " " +  number);
            Console.WriteLine();
                Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
