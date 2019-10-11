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
    public partial class Form4 : Form
    {
        public Form1 f1;
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
    }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.FormA.Enabled = true;
        }
    }
}
