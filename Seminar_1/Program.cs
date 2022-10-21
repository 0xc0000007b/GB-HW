using System;
using System.Linq;
using System.Threading.Tasks;

namespace Seminar_1
{
    internal class Program
    {

        public static void Main(string[] args)
        {


            ///first seminar
            findMax(); // максимальное
            findBiggerInt(); // большое или маленькое
            writeAllNumbersByOne(); // вывод четного, но с нуля
            checkParity(); //parity -> четность

            ///second seminar
            CheckTheWeekDay();
            GetSecondDigitFromNumber();
            FindEndedNumber();


            /// Third seminar
            
            GetQubeTable();
            isPalindrome();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("input a point");
            int xa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int xb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int ya = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int yb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int za = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int zb = Int32.Parse(Console.ReadLine());
            Get3DPoint(xa,xb,ya,yb,xa,zb);


            Console.ReadLine();


        }

        // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
        private static void findMax()
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

            for (int i = 0; i < limit; i += 2)
                Console.WriteLine(i + "");

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

        static void CheckTheWeekDay()
        {
            Console.WriteLine("insert week day nuber" +
                              ": ");
            int day = Int32.Parse(Console.ReadLine());
            if ((day == 7) || (day == 6))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yep, that day is a weekend. REST!!");

            } else if ( day > 7)
            {
                Console.WriteLine("that day has not exist in he week");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GO WORK!! THAT DAY IS NOT A WEEKEND");
            } 
        }

        /// <summary>
        /// SEcond Seminar
        /// (WITH THE GREEN FOREGROUND COLOR)
        /// </summary>


        /// <summary>
        /// THIS METHOD FINDING THE SECOND DIGIT FROM YOUR NUMBER AND WRITING HER IN CONSOLE
        /// (WITH THE GREEN FOREGROUND COLOR)
        /// </summary>

        static void GetSecondDigitFromNumber()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("insert ur Number: ");
            int num = Int32.Parse(Console.ReadLine());
            string str = num.ToString();
            if (str.Length < 3)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("YOU NUMBER IS REALLY SHORTEN!! ");
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"second digit for the {num} equals {str[1]}");
            }


        }

        //this method finding thirst number in number and writing him in console.
        ///////////////////////////////////////////////////////////////////////
        //////////////////////////////WARNING/////////////////////////////////
        ///DONT WRITHE THE NUMBERS WHICH CONTAIN 0 TYPE OF 100, 200, 300/////
        /// BECAUSE METHOD THROWS "your number has no exist thirst digit"///
        ////////////////////////THANK YOU//////////////////////////////////
        //////////////////////////////////////////////////////////////////
        ///////////////////// THAT'S A FITCH  ///////////////////////////
        //////////////////// 0 is not a NUMBER//////////////////////////
        ///////////////////////////////////////////////////////////////
        static void FindEndedNumber()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("insert ur Number: ");
            int a = Int32.Parse(Console.ReadLine());

            int gr = a % 10;
            int gr1 = a / 100;
            string str = a.ToString();
            if (gr == gr1 && str.Length == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"your end number is: {gr}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("your number has no exist thirst digit");
                
            }
        }
        //Task 23
        static void GetQubeTable()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("input your number: ");
            int g = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= g; i++)
            {

                Console.WriteLine($"qube is {i * i * i}");
            }
        }
        //Task 19
        static void isPalindrome()
        {
            int num, res, temp, rem = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("input number: ");
            num = Int32.Parse(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                res = num % 10;
                rem = (rem * 10) + res;
                num = num / 10;
            }
            if (temp == rem && temp >= 10000 && temp <= 99999) Console.WriteLine($"Number {temp} is Palindrome");
            else Console.WriteLine($"{temp} not a Palindrome");
        }


        static void Get3DPoint(int xa,int xb,int ya,int yb,int za,int zb )
        {
           
             double res = Math.Sqrt((((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za))));
            Console.WriteLine($"distantion between points a,b, c, d, e and f equals {res}");
        }

        



    }
}