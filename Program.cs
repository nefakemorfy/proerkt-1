﻿using System;
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
            //Заполнить одномерный массив с клавиатуры шестью целыми числами. Вывести одномерный массив в обратном порядке.
            //Заполнить одномерный массив с клавиатуры шестью целыми числами. Вывести одномерный массив в обратном порядке.

            int[] array = new int[6];
            for (int i = array.Length-1; i>=0; i--)
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
