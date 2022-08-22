//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GenerateArray(13);
            Print(array);
            array = Calculate(array);
            Print(array);
            Console.ReadKey();
        }

        private static int[] Calculate(int[] arr)
        {
            bool odd = arr.Length % 2 != 0;
            int[] result =new int[arr.Length/2+(odd?1:0)];
            for (int i = 0; i < result.Length; i++)
                result[i] = i==result.Length-1?
                    odd?arr[i]: 
                    arr[i] * arr[arr.Length - i - 1]:
                    arr[i] * arr[arr.Length - i-1];
            return result;
        }

        static int[] GenerateArray(int rang)
        {
            //if(rang%2!=0) rang += 1;
            int[] result = new int[rang];
            var rnd = new Random();
            for (int i = 0; i < result.Length; i++)
                result[i] = rnd.Next(1, 9);
            return result;
        }

        static void Print(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}{(i<arr.Length-1?",":"")}");
            }
            Console.Write("]\r\n");
        }
    }
}

