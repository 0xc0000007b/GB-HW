using System;

namespace Seminar_1
{
    public class sem_8
    {
        public  int[,] SpiralArrayFill(int input)
        {
            int[,] arr = new int[input, input];
            for (int curPos = 1, padding = 0; padding < input / 2; padding++)
            {
                for (int j = padding; j < input - padding; j++)
                    arr[padding, j] = curPos;
                for (int j = padding; j < input - padding; j++)
                    arr[input - padding - 1, j] = curPos;
                for (int j = padding + 2; j < input - padding - 1; j++)
                    arr[j, padding] = curPos;
                for (int j = padding + 1; j < input - padding - 1; j++)
                    arr[j, input - padding - 1] = curPos;
                curPos = 1 - curPos;
                arr[padding + 1, padding] = curPos;
            }
            if (input % 2 != 0 && arr[0, 0] == 1) arr[input / 2, input / 2] = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int g = 0; g < arr.GetLength(1); g++)
                { 
                    Console.Write(arr[i,g] + " ");
                }
                Console.WriteLine();
            }
            return arr;
            
        }
        
        
    }
}