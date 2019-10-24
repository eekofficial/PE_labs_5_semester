using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6_Korotaev
{
    class Town
    {
        public string region;
        public string head;
        public double square;

        public void input_town()
        {
            Console.Write("Введите округ: ");
            region = Console.ReadLine();
            Console.Write("Введите главу округа: ");
            head = Console.ReadLine();
            Console.Write("Введите площадь зеленых насаждений: ");
            square = Convert.ToDouble(Console.ReadLine());

        }

        public void output_town()
        {
            Console.WriteLine("Округ: " + this.region);
            Console.WriteLine("Глава округа: " + this.head);
            Console.WriteLine("Площадь зеленых насаждений: " + this.square);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns_list = new List<Town>();
            int n;
            Town elem;
            Console.Write("Введите количество округов: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                elem = new Town();
                elem.input_town();
                towns_list.Add(elem);
            }

            Console.WriteLine();
            Console.WriteLine("Исходные данные:");
            foreach (var town in towns_list)
            {
                town.output_town();
            }

            double max_square = towns_list.Select(r => r.square).Max();
            var heads = towns_list.Where(r => r.square == max_square).Select(p => new { p.head, p.square }).ToList();

            Console.WriteLine("Результат выполнения программы");

            foreach (var head in heads)
            {
                Console.Write("Глава округа: " + head.head + " ");
                Console.WriteLine("Площадь зеленых насаждений: " + head.square);
            }

        }
    }
}
