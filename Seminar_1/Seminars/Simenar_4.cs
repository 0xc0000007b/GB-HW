using System;

namespace Seminar_1
{
    public class Simenar_4
    {
        public static int[] FillRandomNunbers(int n)
        {
            int[] digits = new int[n];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = new Random().Next(0, 100);
                for(int j = 0; j < digits.Length; j++) 
                    Console.Write($"{digits[i]}");
            }

            return digits;
        }
    }
}