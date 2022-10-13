using System;
using System.Linq;

namespace Seminar_1
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
           findMax();
           findBiggerInt();
           writeAllNumbersByOne();
           checkParity();

        }
        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
        private  static void findMax()
        {
            Console.WriteLine("Please, input your number bellow: ");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            
            if (a > b && a > c)
                Console.WriteLine("Number Max = " + a); 
            else if (b > c)
                Console.WriteLine("Number Max = " + b); 
            else
                Console.WriteLine("Number Max = " + c); 
            
        }
        
        // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

        private static void writeAllNumbersByOne()
        {
            Console.WriteLine("Please, input your number bellow: ");
            int limit = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i< limit ; i+=2)
                Console.WriteLine(i + "" );
            
        }
        
        
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        private static void findBiggerInt()
        {
            Console.WriteLine("Please, input your number bellow: ");
            int a = Int32.Parse(Console.ReadLine()), b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine($"All Right. int {a} less than {b}");
                
            }
            else
            {
                Console.WriteLine($"Wrong!!. int {a} Bigger than {b}");
            }
            
        }
        
        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        private static void checkParity()
        {
            Console.WriteLine("inout your int bellow, please: ");
            int s = Int32.Parse(Console.ReadLine());

            if (s % 2 == 0)
            {
                Console.WriteLine("this number is parity");
            }
            else
            {
                Console.WriteLine("this number is not parity");
            }
        }  
        
        
    }
}