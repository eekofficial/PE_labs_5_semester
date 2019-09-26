using System;


namespace Lab1_Korotaev
{
    class Program
    {
        static void MatrixInput(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Please, enter element [" + (i + 1) + ", " + (j + 1) + "]: ");
                            x[i, j] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch { }
                    }
                }
            Console.WriteLine();

        }

        static void PrintMatrix(int[,] x)
        {
            Console.WriteLine("Current values of matrix:");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static bool Symmetric(int[,] x) // returns true if matrix is symmetric
        {
            for (int i = 0; i < x.GetLength(0) - 1; i++)
                for (int j = i + 1; j < x.GetLength(1); j++)
                {
                    if (x[i, j] != x[j, i])
                    {
                        return false;
                    }
                }
            return true;
        }

        static void AboveDiagToZero(int [,] x) // function which zeroizes every element above the giagonal
        {
            for (int i = 0; i < x.GetLength(0) - 1; i++)
                for (int j = i + 1; j < x.GetLength(1); j++)
                {
                    x[i, j] = 0;
                }
        }

        static void BelowDiagSum(out int sumx, int[,] x) // function which calculetes sum of elements below the diagonal
        {
            sumx = 0;
            for (int i = 1; i < x.GetLength(0); i++)
                for (int j = 0; j < i; j++)
                {
                    sumx += x[i, j];
                }
        }

        static void Main(string[] args)
        {
            int[,] a; // matrix
            int n; // number of rows and columns in matrix
            while (true)
            {
                try
                {
                    Console.Write("Please, enter the number of rows and columns in matrix: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    a = new int[n, n];
                    break;
                }
                catch { }
            }

            MatrixInput(a);
            PrintMatrix(a);

            if (Symmetric(a))
            {
                AboveDiagToZero(a);
                PrintMatrix(a);
                Console.Write("Sum of elements which lies below diagonal: ");
                BelowDiagSum(out int sum, a);
                Console.WriteLine(sum);
            }

        }
    }
}
