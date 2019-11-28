using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_PE_Korotaev
{
    public partial class Form1 : Form
    {
        List<Town> towns_list = new List<Town>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_last_Click(object sender, EventArgs e)
        {
            if ((region.Text.Length > 0) && (head.Text.Length > 0) && (Convert.ToInt32(area.Text) >= 0))
            {
                service_box.Text = "";
                Town elem = new Town(region.Text, head.Text, Convert.ToInt32(area.Text));
                towns_list.Add(elem);
                count.Text = Convert.ToString(towns_list.Count());
            }
            else
            {
                service_box.Text = "Введите округ, главу округа и площадь зеленых насаждений в полях ниже";
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if (towns_list.Count > Convert.ToInt32(index.Text))
                {
                    service_box.Text = "";
                    task_box.Text = towns_list[Convert.ToInt32(index.Text)].output_town();
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else
            {
                service_box.Text = "Введите индекс элемента";
            }
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            if (towns_list.Count > 0)
            {
                service_box.Text = "";
                task_box.Text = towns_list[0].output_town();
                for (int i = 1; i < towns_list.Count; i++)
                {
                    task_box.Text += towns_list[i].output_town();
                }
            }
            else
            {
                service_box.Text = "В списке отсутствуют элементы";
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if (towns_list.Count > Convert.ToInt32(index.Text))
                {
                    if ((region.Text.Length > 0) && (head.Text.Length > 0) && (Convert.ToInt32(area.Text) >= 0))
                    {
                        service_box.Text = "";
                        towns_list[Convert.ToInt32(index.Text)].region = region.Text;
                        towns_list[Convert.ToInt32(index.Text)].head = head.Text;
                        towns_list[Convert.ToInt32(index.Text)].area = Convert.ToInt32(area.Text);
                    }
                    else
                    {
                        service_box.Text = "Введите округ, главу округа и площадь зеленых насаждений в полях ниже";
                    }
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else
            {
                service_box.Text = "Введите индекс элемента";
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if ((towns_list.Count > Convert.ToInt32(index.Text)) && (Convert.ToInt32(index.Text) > 0))
                {
                    service_box.Text = "";
                    index.Text = Convert.ToString(Convert.ToInt32(index.Text) - 1);
                    task_box.Text = towns_list[Convert.ToInt32(index.Text)].output_town();
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else
            {
                service_box.Text = "Введите индекс элемента";
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if ((towns_list.Count > Convert.ToInt32(index.Text)) && (Convert.ToInt32(index.Text) < towns_list.Count - 1))
                {
                    service_box.Text = "";
                    index.Text = Convert.ToString(Convert.ToInt32(index.Text) + 1);
                    task_box.Text = towns_list[Convert.ToInt32(index.Text)].output_town();
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else
            {
                service_box.Text = "Введите индекс элемента";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if (towns_list.Count > Convert.ToInt32(index.Text))
                {
                    if ((region.Text.Length > 0) && (head.Text.Length > 0) && (Convert.ToInt32(area.Text) >= 0))
                    {
                        service_box.Text = "";
                        Town elem = new Town(region.Text, head.Text, Convert.ToInt32(area.Text));
                        towns_list.Insert(Convert.ToInt32(index.Text), elem);
                        count.Text = Convert.ToString(towns_list.Count());
                    }
                    else
                    {
                        service_box.Text = "Введите округ, главу округа и площадь зеленых насаждений в полях ниже";
                    }
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else 
            {
                service_box.Text = "Введите индекс элемента";
            } 
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (index.Text.Length > 0)
            {
                if (towns_list.Count > Convert.ToInt32(index.Text))
                {
                    service_box.Text = "";
                    towns_list.RemoveAt(Convert.ToInt32(index.Text));
                    count.Text = Convert.ToString(towns_list.Count());
                }
                else
                {
                    service_box.Text = "В списке не существует элемента с таким индексом";
                }
            }
            else
            {
                service_box.Text = "Введите индекс элемента";
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (towns_list.Count > 0)
            {
                service_box.Text = "";
                double max_square = towns_list.Select(r => r.area).Max();
                var heads = towns_list.Where(r => r.area == max_square).Select(p => new { p.head, p.area }).ToList();
                task_box.Text = "";
                foreach (var head in heads)
                {
                    task_box.Text += String.Format("Глава округа: {0}\r\n", head.head);
                    task_box.Text += String.Format("Площадь зеленых насаждений: {0}\r\n\r\n", head.area);
                }
            }
            else
            {
                service_box.Text = "В списке отсутствуют элементы";
            }  
        }
    }
    }

