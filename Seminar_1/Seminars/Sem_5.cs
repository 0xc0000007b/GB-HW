using System;
using System.Linq;

namespace Seminar_1
{
    public class Sem_5
    {
        public void FindHonesCountOfArrayElements(int[] arr)
        {
            int count = 0;
            int idx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                idx = arr[i];
                arr[i] = new Random().Next(100, 999);
                if (arr[i] % 2 == 0) count++;

            }

            Console.WriteLine($"i  find the {count} honest digits in this array");
        }

        public void FindSumOfOddNumbersInArrayElements(int[] g)
        {

            int sum = 0;
            for (int i = 1; i < g.Length; i += 2)
            {
                g[i] = new Random().Next(100, 999);
                if (g[i] % 2 != 0) sum += g[i];

            }

            Console.WriteLine($"i  find  sum  of the odd numbers in the array, his equals is: {sum}");
        }

        public void FindDifferenceBetweenArrayElements()
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            int min = 100, max = 0;
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(100);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
              
            }

            for (int i = 0; i < arr.Length; i++)Console.Write(" " + arr[i]);
            Console.WriteLine();
            int difference = max - min;
            Console.WriteLine($"difference between {max} and {min} indexes equals: {difference}  ");
        }
    }
}