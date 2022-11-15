using System;

namespace Seminar_1
{
    public class Seminar_6
    {
        public void PositiveCount()
        {
            Console.WriteLine("input the numbers bellow: ");

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) count++;
            }
            Console.WriteLine($"Positive number count is: {count}");
        }

        public void FidCenter(double k1, double b1, double k2, double b2)
        {
            double x = (b1 - b2) / (k1 - k2);
            double y = k1 * x + b1;
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            Console.WriteLine($"Переечения прямых в точках x: {x}, and y: {y}");
        }


    }
}