using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tab tuşuna iki defa basılırsa if bloğu açılır.
            var number = 10;

            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10.");
            //}
            //else if {
            //    Console.WriteLine("Number is 20")
            //}
            //else
            //{
            //    Console.WriteLine("Number isn't 10 or 20.");
            //}

            //Bu iki komutu yazmak yerine şu yazılabilir.
            //Console.WriteLine(number == 10 ? "Number is 10." : "Number isn't 10.");

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10.");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20.");
            //        break;
            //    default:
            //        Console.WriteLine("Number isn't 10 or 20.");
            //        break;
            //}

            //Üstteki İf şartlarını kullanmak yerine switch de kullanabiliriz.


            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100.");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 0-100.");
            //}
            //else if (number < 0 || number > 200)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            if (number < 100)
            {
                if (number >= 90 && number <= 95)
                {
                    Console.WriteLine("Number is between 90-95");
                }
            }

            Console.ReadLine();
        }
    }
}
