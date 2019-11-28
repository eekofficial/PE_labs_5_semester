using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab2_Library;
using System.Data;

namespace Lab7_Korotaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

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
                x1[i + 1].DefaultValue = "0";
            }
            for (int i = 0; i < n; i++)
            {
                DataRow y = Tabel.NewRow();
                Tabel.Rows.Add(y);
                Tabel.Rows[i][0] = i + 1;
            }
            x2.ReadOnly = true;
            input.ItemsSource = Tabel.DefaultView;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void negativinlast_Click(object sender, RoutedEventArgs e)
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

        private void input_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void create_matrix_Click(object sender, RoutedEventArgs e)
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

        private void fill_matrix_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                matrix = new Lab2_Library.Matrix(Tabel.Rows.Count, Tabel.Columns.Count, Tabel);
                output.Text = "Матрица заполнена";
            }
            catch
            {
                output.Text = "Создайте матрицу";
            }
        }
    }
}
