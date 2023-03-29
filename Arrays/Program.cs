using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            {
                students[0] = "Ekrem";
                students[1] = "İbrahim";
                students[2] = "Baran";
            }
            string[] students2 = new[] {"Engin","Derin","Salih"};

            string[] students3 = {"Ekrem","İbrahim","Baran"};

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            foreach (string student in students3)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Van","Gümüşhane"},
                {"Ankara","Mersin","Konya"},
                {"İzmir","Ağrı","Bursa"},
                {"Antalya","Trabzon","Hakkari"},
                {"Aydın","Denizli","Samsun"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("-----------");
                for (int j = 0;j <= regions.GetUpperBound(1);j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
            // GetUpperBound(0) sütunları GetUpperBound(1) satırları temsil eder.

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
