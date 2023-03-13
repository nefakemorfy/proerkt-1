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
            // Заполнить одномерный массив (с использованием явной инициализации). Подсчитать количество отрицательных элементов одномерного массива.

                int[] arr = { -37, 0, 50, 46, 34, 46, -4, 13 };
                int count = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Количество отрицательных элементов: {count}");
                Console.Read(); 
        }
    }
}
