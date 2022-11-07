using System;

namespace Seminar_1
{
    public class Sem_2
    {
        public  void CheckTheWeekDay()
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

        public  void GetSecondDigitFromNumber()
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
        public  void FindEndedNumber()
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

    }
}