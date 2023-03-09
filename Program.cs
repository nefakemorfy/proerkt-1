using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"array[{i}]={array[i]}");
            }
            Console.Read();
        }
    }
}
