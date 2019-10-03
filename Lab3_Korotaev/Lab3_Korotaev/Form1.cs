using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2_Library;


namespace Lab3_Korotaev
{
    public partial class Form1 : Form
    {
        Lab2_Library.Matrix matrix;
        DataTable Tabel;
        void InitGrid(int n, int m)
        {
            Tabel = new DataTable();
            DataColumn x2 = Tabel.Columns.Add("First   ", typeof(Int32));
            DataColumnCollection x1 = Tabel.Columns;
            
            for (int i = 0; i < m; i++)
            {
                x1.Add("Col " + (i + 1), typeof(Int32));
                x1[i+1].DefaultValue = "0";
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Input_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Input_matrix_Click(object sender, EventArgs e)
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
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Fill_matrix_Click(object sender, EventArgs e)
        {
            try
            {
                matrix = new Lab2_Library.Matrix(Tabel.Rows.Count, Tabel.Columns.Count, Tabel);
                output.Text = "Матрица заполнена";
            }  
            catch {
                output.Text = "Создайте матрицу";
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Negativinlast_Click(object sender, EventArgs e)
        {
            try
            {
                matrix.NegativeInLast();
                output.Text = matrix.PrintStringMatrix();
            }
            catch
            {
                output.Text = "Создайте и заполните матрицу";
            }
        }

        private void Positivelines_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = matrix.PrintPositiveMatrixInTextField();
            }
            catch
            {
                output.Text = "Создайте и заполните матрицу";
            }
        }

        private void Input_m_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
