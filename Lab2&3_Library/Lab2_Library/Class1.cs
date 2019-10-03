using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Lab2_Library
{
    public class DynamicArray
    {
        protected List<List<int>> array = new List<List<int>>();
        public DynamicArray(int n)
        {
            for (int i = 0; i < n; i++)
            {
                array.Add(new List<int>());
            }
        }
    }

    public class Matrix : DynamicArray
    {
        List<List<int>> matrix = new List<List<int>>();
        public Matrix(int n, int m) : base(n)
        {
            int el;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Please, enter element [" + (i + 1) + ", " + (j + 1) + "]: ");
                            el = Convert.ToInt32(Console.ReadLine());
                            array[i].Add(el);
                            break;
                        }
                        catch { }
                    }
                }
        }

        public Matrix(int n, int m, DataTable tabel) : base(n)
        {
            int el;
            for (int i = 0; i < n; i++)
                for (int j = 1; j < m; j++)
                {
                    el = Convert.ToInt32(tabel.Rows[i][j]);
                    array[i].Add(el);
                    }
        }

        public void PrintMatrix()
        {
            Console.WriteLine();
            Console.WriteLine("Current Matrix:");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public string PrintStringMatrix()
        {
            StringBuilder sb = new StringBuilder();
            string str = "";
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    str += Convert.ToString(array[i][j]);
                    str += " ";
                }
                sb.AppendLine(str);
                str = "";
            }
            return sb.ToString();
        }
        public void NegativeInLast()
        {
            int tmp;
            int count;
            for (int j = 0; j < array[0].Count; j++)
                for (int i = 0; i < array.Count / 2; i++)
                {
                    count = array.Count - 1;
                    if (array[i][j] < 0)
                    {
                        while (array[count][j] < 0)
                        {
                            count--;
                        }
                        tmp = array[count][j];
                        array[count][j] = array[i][j];
                        array[i][j] = tmp;
                        count--;
                    }
                }
        }

        public void PrintPositiveMatrix()
        {
            Console.WriteLine();
            Console.WriteLine("Matrix without rows with negative elements:");
            for (int i = 0; i < array.Count; i++)
            {
                if (!(IfHaveNegative(i)))
                {
                    for (int j = 0; j < array[i].Count; j++)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public string PrintPositiveMatrixInTextField()
        {
            StringBuilder sb = new StringBuilder();
            string str = "";
            for (int i = 0; i < array.Count; i++)
            {
                if (!(IfHaveNegative(i)))
                {
                    for (int j = 0; j < array[i].Count; j++)
                    {
                        str += Convert.ToString(array[i][j]);
                        str += " ";
                    }
                }
                sb.AppendLine(str);
                str = "";
            }
            return sb.ToString();
        }

        private bool IfHaveNegative(int i)
        {
            for (int j = 0; j < array[i].Count; j++)
            {
                if (array[i][j] < 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
