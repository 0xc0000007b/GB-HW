using System;

namespace Seminar_1
{
    public class Sem_7
    {
        public  double[,] CreateRandom2DArray(int cols, int rows)
        {
            Console.WriteLine("input min numbber: ");
            double min = Math.Round(Double.Parse(Console.ReadLine()));
            Console.WriteLine("input max numbber: ");
            double max = Math.Round(Double.Parse(Console.ReadLine()));
            double[,] arr = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = Math.Round(new 
                        Random().NextDouble() * ((-max) - min) + min);
                    
                    Console.Write(arr[i,j ]+ " ");
                }
                
                Console.WriteLine();
            }
            return arr;


        }
       
        public void FindIndexIn2DArray()
        {
            Console.WriteLine("input rows count");
            int rows = int.Parse(Console.ReadLine());
                
            Console.WriteLine("input cols count");
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine("input min numbber: ");
            double min = Math.Round(Double.Parse(Console.ReadLine()));
            Console.WriteLine("input max numbber: ");
            double max = Math.Round(Double.Parse(Console.ReadLine()));
            Console.WriteLine("input coords: ");
            int c = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
           
            double[,] array = new double[rows, cols];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Math.Round(new Random()
                                                 .NextDouble() 
                                             * (max - min)
                                             - min);
            }

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i,j] + "\t  ");
                Console.WriteLine();
            }
            if (c > cols && r > rows) Console.WriteLine($"number {c} not exists in array");
            else 
            {
                    object num = array.GetValue(c,r);
                    Console.WriteLine($"The number which position is {r} an {c}  is {num}"); 
            }
        }
        public void FindMidArifmethicIn2DArray()
        {
     
            double[,] array = new double[5,5];
            double[] num = new double[5];
            double sum = 0;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * j + 1;
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1,k=0; i < array.GetLength(0); i+=2)
            {
                for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
                num[k] = sum / 5;
                Console.WriteLine($"Среднее арифметическое столбца "+(i+1)+" равно: "+ num[k]);

            }
            
        }
    }
}