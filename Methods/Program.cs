using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add("Ali");
            Add("Veli");Add("Return aldiğim");
            Console.Write("İsim girin: ");
            string gelenDeger = Console.ReadLine();
            Console.WriteLine(gelenDeger);
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi1+sayi2);
            var result = Add2(20,30);
            //var result = Add2(20); Yorum panelindeki şeklinde tanımlanırsa tek değişken girilir.
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #region ADD METHOD
        static void Add(string name) 
        {
            Console.WriteLine(name);
            //return name;
        }
        #endregion
        static int Add2(int number1, int number2)
        //static int Add2(int number1, int number2=30) şeklinde değer tanımlayabiliriz. Tüm değişkenlere değer atanabilir,
        // Ama sadece ilk değişkene değer verilip diğer değişkenlere verilmez ise çalışmaz.
        {
            var result = number1 + number2;
            return result; 
        }
    }
}
