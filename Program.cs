using System;
/*
Exercises C# StackMatrixElements
Write program that read a matrix from console and print:
•Count of rows •	Count of columns •	Sum of all matrix elements
Date: 30/10/2020
*/
namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Matrix Elements");
            Console.WriteLine("Enter no.of rows in your matrix:");
            int rows = Convert.ToInt32(Console.ReadLine());
           
            //Jagged arrays are arrays of arrays
            int[][] intJaggedArray = new int[rows][];
            int max=0;
            for(int i=0; i<rows; i++)
                {
                Console.WriteLine("Enter no.of columns for row" + i);
                int columns = Convert.ToInt32(Console.ReadLine());
                if(columns>max)
                max = columns;
                intJaggedArray[i] = new int[columns];
                
            }
            Console.WriteLine("Enter the elements of matrix:");
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Enter the elements of row"+ i);
                foreach (int num in intJaggedArray[i])
                {
                    intJaggedArray[i][num] = Convert.ToInt32(Console.ReadLine());
                    sum += intJaggedArray[i][num];

                }

            }
            Console.WriteLine("Max. No.of rows   :" + rows);
            Console.WriteLine("Max. No.of columns:" + max);
            Console.WriteLine("sum of matrix is  :" + sum);


        }
    }
}
