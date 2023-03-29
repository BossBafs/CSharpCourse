using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // integer sayı sınırı -2147483648 ile 2147483647'dır. Bundan büyük olan sayılar ise long keywordu ile yazılır.
            // long sayı sınırı -9223372036854775808 ile 9223372036854775807'dır.
            // short sayı sınırı -327688 ile 327687'dir.
            // byte sayı sınırı 0 ile 255'dir.
            // double da noktadan sonra en fazla 15-16 digit kullanılabilir.
            // decimal da noktadan sonra en fazla 28-29 digit kullanılabilir. Tam sayılar da kullanılabilir.

            // Sayı sınırları belirtilen keywordları sınırları çerçevesinde kullanmak daha az byte yer kaplar.


            int number1 = 2147483647;
            long number2 = -9223372036854775808;
            long number3 = -327688;
            byte number4 = 0;
            double number5 = 20.455;
            decimal number6 = 52.5974611188m;
            char character = 'A';
            string city = "Ankara";
            bool conditional = false;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine("City is {0}", city);
            Console.WriteLine(conditional);
            Console.WriteLine(Days.Tuesday);
            Console.WriteLine((int)Days.Tuesday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday = 30, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
