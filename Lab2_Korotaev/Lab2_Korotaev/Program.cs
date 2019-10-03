using System;
using Lab2_Library;

namespace Lab2_Korotaev
{

    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Lab2_Library.Matrix matrix;

            while (true)
            {
                try
                {
                    Console.Write("Please, enter the number of rows in matrix: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please, enter the number of columns in matrix: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    matrix = new Lab2_Library.Matrix(n, m);
                    break;
                }
                catch { }
            }
            matrix.PrintMatrix();
            matrix.NegativeInLast();
            matrix.PrintMatrix();
            matrix.PrintPositiveMatrix(); 
        }
    }
}
