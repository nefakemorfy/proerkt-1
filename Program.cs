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
            //Массив предназначен для хранения значений весов двадцати человек. С помощью датчика случайных чисел заполнить массив вещественными значениями, лежащими в диапазоне от 50 до 100 включительно.Определить средний вес.

            
                double[] weights = new double[20];
                double sum = 0;

                Random rnd = new Random();

                for (int i = 0; i < weights.Length; i++)
                {
                    weights[i] = rnd.NextDouble() * 50 + 50;
                    sum += weights[i];
                }

                double average = sum / weights.Length;

                Console.WriteLine($"Средний вес: {average:f2} кг");

                Console.Read(); 
        }
    }
}
