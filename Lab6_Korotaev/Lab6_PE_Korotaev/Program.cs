using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_PE_Korotaev
{
    class Town
    {
        public string region;
        public string head;
        public double area;

        public Town(string _region, string _head, int _area)
        {
            region = _region;
            head = _head;
            area = _area;
        }

        public string output_town()
        {
            string about_town = "";
            about_town = String.Format("Округ: {0}\r\n", region);
            about_town += String.Format("Глава округа: {0}\r\n", head);
            about_town += String.Format("Площадь зеленых насаждений: {0}\r\n\r\n", area);
            return about_town;
        }
        public string output_town(bool fl)
        {
            string about_town = "";
            about_town += String.Format("Глава округа: {0}\r\n", head);
            about_town += String.Format("Площадь зеленых насаждений: {0}\r\n\r\n", area);
            return about_town;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
