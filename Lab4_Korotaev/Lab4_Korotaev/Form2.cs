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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (interval.Checked)
            {
                value_label2.Visible = true;
                value2.Visible = true;
                value_label1.Text = "Значение a";
            }
        }

        private void MoreValue_CheckedChanged(object sender, EventArgs e)
        {
            value_label2.Visible = false;
            value2.Visible = false;
            value_label1.Text = "Значение";
        }

        private void Hide_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void More_value_CheckedChanged(object sender, EventArgs e)
        {
            value_label2.Visible = false;
            value2.Visible = false;
            value_label1.Text = "Значение";
        }
    }
}
