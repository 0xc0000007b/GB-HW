using System;


namespace Seminar_1
{
    internal class Program
    {

        private static Sem_1 s_1 = new Sem_1();
        private static Sem_2 s_2 = new Sem_2();
        private static Sem_3 s_3 = new Sem_3();
        private static Simenar_4 s_4 = new Simenar_4();
        private  static Sem_5 s_5 = new Sem_5();
        private static Seminar_6 s_6 = new Seminar_6();
        public static void Main(string[] args)
        {
             ///first seminar
             s_1.findMax(); // максимальное
             s_1.findBiggerInt(); // большое или маленькое
             s_1.writeAllNumbersByOne(); // вывод четного, но с нуля
             s_1.checkParity(); //parity -> четность
            
             ///second semina
             s_2.CheckTheWeekDay();
             s_2.GetSecondDigitFromNumber();
             s_2.FindEndedNumber();
            
            
             /// Third seminar
                 Console.ResetColor();
             s_3.GetQubeTable();
             s_3.isPalindrome();
             var xa = GetNumbers(out var xb, 
                                     out var ya, 
                                     out var yb, 
                                     out var zb);
             s_3.Get3DPoint(xa,xb,ya,yb,xa,zb);
            
            
            //Sem 4
             Console.ResetColor();
             Console.WriteLine("input the length of array bellow: ");
             int n = Int32.Parse(Console.ReadLine());
             s_4.FillRandomNunbers(n);
             Console.WriteLine("input the number bellow: ");
             int v = Int32.Parse(Console.ReadLine());
             s_4.FindSun(v);
             Console.WriteLine("input firs num: ");
             int x = Int32.Parse(Console.ReadLine());
             Console.WriteLine("input second num: ");
             int y = Int32.Parse(Console.ReadLine());
             s_4.FindDegree(x, y);
            
            //sem 5;
            int[] arr = new int[5];
            s_5.FindHonesCountOfArrayElements(arr);
            int[] g = new int[5];
            s_5.FindSumOfOddNumbersInArrayElements(g);
            s_5.FindDifferenceBetweenArrayElements();
            
            //sem_6
            s_6.PositiveCount();
            Console.Write("Введите k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            s_6.FidCenter(k1 ,b1, k2, b2);
        }

        private static int GetNumbers(out int xb, out int ya, out int yb, out int zb)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("input a point");
            int xa = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            xb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            ya = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            yb = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            int za = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input a point");
            zb = Int32.Parse(Console.ReadLine());
            return xa;
        }
    }
}