using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        // Değer ve Referans Tipleri
        static void Main(string[] args)
        {
            int Number = 0;
            int Number2 = 10;
            Number2 = Number;
            Number = 30;
            Console.WriteLine(Number2);

            string[] cities = new string[] { "Ankara", "Adana", "Afyonkarahisar" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            cities[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable= new DataTable();
            // dataTable'a dataTable'ın referansı tanımlandığı için newlemeye gerek kalmaz.
            // DataTable dataTable; şeklinde yazmalıyız.
            DataTable dataTable1= new DataTable();
            dataTable = dataTable1;


            Console.ReadLine();
        }
    }
}
