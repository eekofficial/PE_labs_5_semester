using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Korotaev
{
    public partial class Form3 : Form
    {
        public int[,] matrix;
        DataTable Tabel;
        public Form2 f22;
        void InitGrid(int n, int m)
        {
            Tabel = new DataTable();
            DataColumn x2 = Tabel.Columns.Add("First   ", typeof(Int32));
            DataColumnCollection x1 = Tabel.Columns;

            for (int i = 0; i < m; i++)
            {
                x1.Add("Col " + (i + 1), typeof(Int32));
                x1[i + 1].DefaultValue = "0";
            }
            for (int i = 0; i < n; i++)
            {
                DataRow y = Tabel.NewRow();
                Tabel.Rows.Add(y);
                Tabel.Rows[i][0] = i + 1;
            }
            x2.ReadOnly = true;
            input.DataSource = Tabel;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private int SearchMinIndex(ref int[] mas)
        {
            int min = mas[0];
            int ind_min = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    ind_min = i;
                }
            }
            return ind_min;
        }

        private void Negativinlast_Click(object sender, EventArgs e)
        {
            try
            {
                int[] count_mas = new int[matrix.GetLength(0)];  
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (f22.more_value.Checked && matrix[i, j] > Convert.ToInt32(f22.value1.Text))
                        {
                            sum += 1;
                        }
                        if (f22.less_value.Checked && matrix[i, j] < Convert.ToInt32(f22.value1.Text))
                        {
                            sum += 1;
                        }
                        if (f22.interval.Checked && matrix[i, j] > Convert.ToInt32(f22.value1.Text) && matrix[i, j] < Convert.ToInt32(f22.value2.Text))
                        {
                            sum += 1;
                        }
                    }
                    count_mas[i] = sum;
                }
         
                output.Text = Convert.ToString(SearchMinIndex(ref count_mas));
            }
            catch
            {
                output.Text = "Создайте и заполните матрицу, а также введите значение";
            }
        }

        private void Create_matrix_Click(object sender, EventArgs e)
        {
            int n, m;
            try
            {
                n = Convert.ToInt32(input_n.Text);
                m = Convert.ToInt32(input_m.Text);
                if ((n > 0) & (m > 0))
                {
                    InitGrid(n, m);
                    output.Text = "Матрица создана, заполните ее";
                }
                else
                {
                    output.Text = "Проверьте правильность ввода размерности";
                }

            }
            catch
            {
                output.Text = "Проверьте правильность ввода размерности";
            }
        }

        private void Fill_matrix_Click(object sender, EventArgs e)
        {
            try
            {
                matrix = new int[Tabel.Rows.Count, Tabel.Columns.Count - 1];
                for (int i = 0; i < Tabel.Rows.Count; i++)
                {
                    for (int j = 1; j < Tabel.Columns.Count; j++)
                    {
                        matrix[i, j - 1] = Convert.ToInt32(Tabel.Rows[i][j]);
                    }
                }
                    
                output.Text = "Матрица заполнена";
            }
            catch
            {
                output.Text = "Создайте матрицу";
            }
        }

        private void Form_array_Click(object sender, EventArgs e)
        {
            try
            {
                string max_elems = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int max = matrix[i, 0];
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                    max_elems = max_elems + Convert.ToString(max) + " ";
                }
                output.Text = max_elems;
            }
            catch
            {
                output.Text = "Создайте и заполните матрицу";
            }
        }
    }
}
