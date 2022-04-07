using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //2DArray declaration
            Console.WriteLine("Fixed 2d array");
            int[,] grades =
            {
                { 5, 4, 7, 3 },
                { 7, 3, 2, 6 },
                { 5, 3, 7, 3}
            };

            //Get row(0) length
            Console.WriteLine($"row length is: {grades.GetLength(0)}");
            //Get column(1) length
            Console.WriteLine($"column length is: {grades.GetLength(1)}");

            //Display 2D Array contents
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.Write(grades[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // dynamic
            Console.WriteLine("Dynamic 2d array");
            Console.WriteLine("Enter rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns:");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // enter values for declared array
            int[,] x = new int[rows, columns];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write($"row{i + 1}: | column{j + 1}: ");
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nOutput:");

            // output array
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
