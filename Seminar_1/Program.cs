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
        private static Sem_7 s_7 = new Sem_7();
        private static sem_8 s_8 = new sem_8();
        public static void Main(string[] args)
        {
            //first seminar
            SeminarOneMethodsColling();
            //second semina
            SeminarTwoMethodsColling();
            // Third seminar
            SeminarThreeMethodsColling();
            //Sem 4
            SeminarFourMethodsColling();
            //sem 5;
            SeminarFiveMethodsColling();
            //sem_6
            SeminarSixMethodsColling();
            // Semimar 7
            SeminarSevenMethodsColling();
            //sem_8
            SeminarEightMethodsColling();
        }

        private static void SeminarOneMethodsColling()
        {
            s_1.findMax(); // максимальное
            s_1.findBiggerInt(); // большое или маленькое
            s_1.writeAllNumbersByOne(); // вывод четного, но с нуля
            s_1.checkParity(); //parity -> четность
        }

        private static void SeminarTwoMethodsColling()
        {
            s_2.CheckTheWeekDay();
            s_2.GetSecondDigitFromNumber();
            s_2.FindEndedNumber();
        }

        private static void SeminarThreeMethodsColling()
        {
            Console.ResetColor();
            s_3.GetQubeTable();
            s_3.isPalindrome();
            var xa = GetNumbers(out var xb,
                out var ya,
                out var yb,
                out var zb);
            s_3.Get3DPoint(xa, xb, ya, yb, xa, zb);
        }

        private static void SeminarFourMethodsColling()
        {
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
        }

        private static void SeminarFiveMethodsColling()
        {
            int[] arr = new int[5];
            s_5.FindHonesCountOfArrayElements(arr);
            int[] g = new int[5];
            s_5.FindSumOfOddNumbersInArrayElements(g);
            s_5.FindDifferenceBetweenArrayElements();
        }

        private static void SeminarSixMethodsColling()
        {
            s_6.PositiveCount();
            Console.Write("Введите k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            s_6.FidCenter(k1, b1, k2, b2);
        }

        private static void SeminarSevenMethodsColling()
        {
            Console.Write("input rows count bellow: ");
            int rows = Int32.Parse(Console.ReadLine());
            Console.Write("input cols count bellow: ");
            int cols = Int32.Parse(Console.ReadLine());
            s_7.CreateRandom2DArray(rows, cols);
            s_7.FindIndexIn2DArray();
            s_7.FindMidArifmethicIn2DArray();
        }

        private static void SeminarEightMethodsColling()
        {
            Console.WriteLine("input the cols ind rows count:");
            int input = int.Parse(Console.ReadLine());
            s_8.SpiralArrayFill(input);
            Console.WriteLine();
            Console.WriteLine("input col count:");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("input rows count:");
            int row = int.Parse(Console.ReadLine());
            s_8.CreateAAndPrintMatrix(row, col);
            Console.WriteLine();

            Console.WriteLine("input col count:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("input rows count:");
            int r = int.Parse(Console.ReadLine());
            s_8.BubbleSortingToDown(r, c);
            int colz = int.Parse(Console.ReadLine());
            int rowz = int.Parse(Console.ReadLine());
            s_8.MultipleMatrix(rowz, colz);
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