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
            ab1 = new AboutBox1();
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
            f3.MdiParent = this;
            f3.Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = MdiChildren.Length - 1; i >= 0; i--)
            {
                MdiChildren[i].Close();
            }
        }

        private void CloseActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MosaikaVerticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MosaikaHorisontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void SingleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4;
            f4 = new Form4();
            f4.MdiParent = this;
            FormA.Enabled = false;
            f4.f1 = this;
            f4.Show();
        }
    }
}
