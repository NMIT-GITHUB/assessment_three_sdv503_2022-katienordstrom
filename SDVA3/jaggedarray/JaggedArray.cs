// See https://aka.ms/new-console-template for more information

// C# program to find maximum element in a jagged array
using System;

class KatiesA3
{

    //Max element function
    public static void maxNumber(int jagArray, int[][] arr)
    {
        int i = 0;

        // Max is initialised to 0
        int max = 0;
        int[] largestNum = new int[jagArray];
        while (i < jagArray)
        {
            for (int j = 0;
                    j < arr[i].Length; j++)
            {
                if (arr[i][j] > max)
                {
                    max = arr[i][j];
                }
            }
            largestNum[i] = max;
            max = 0;
            i++;

        }
        printArray(largestNum);

    }

    // Print array element
    private static void printArray(int[] largestNum)
    {
        for (int i = 0; i < largestNum.Length; i++)
        {
     
            Console.WriteLine(largestNum[i]);
        }

    }

    
    public static void Main(string[] args)
    {
        int[][] arr = new int[][]
        {
        new int[] {4,2,7,1},
        new int[] {20,70,40,90},
        new int[] {1, 2, 0}
        };

        // Calling the function
        maxNumber(3, arr);
    }
}


