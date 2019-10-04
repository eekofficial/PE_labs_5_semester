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
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f2.Show();


        }

        private void WindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1;
            ab1 = new AboutBox1(true);
            ab1.ShowDialog();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3;
            f3 = new Form3();
            f3.f22 = f2;
            f3.Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
