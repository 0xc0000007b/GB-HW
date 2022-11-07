using System;

namespace Seminar_1
{
    public class Simenar_4
    {
        public  int[] FillRandomNunbers(int n)
        {
            Console.Write("\b"+"[");
            int[] digits = new int[n];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = new Random().Next(0, 100);
                for(int j = 0; j < digits.Length; j++) 
                    Console.Write($"{digits[i]}, ");
            }
            Console.WriteLine("\b"+"]");

            return digits;
        }

        public void FindSun(int v)
        {
            int s = 0;
            while (v > 0)
            {
     
                s = s + v % 10;
                v = v /10 ;
     
            }
            Console.WriteLine(s);
        }

        public void  FindDegree(int x, int y)
        {
            int res = 1;
            for (int i = 1; i <= y; i++)
            {
                res *= x;
                
            }
            
            Console.WriteLine("your expanation is : " + res);
        }
    }
}