using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
        private static void WhileLoop()
        {
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
        }
        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=11);
            Console.ReadLine();
            // Do döngüsü şartı sağlamasa bile ilk adımı çalıştırır.
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (string student in students) 
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number-1; i++) 
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        static void Main()
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a Prime Number.");
            }
            else
            {
                Console.WriteLine("This is a not Prime Number.");
            }

            //bool deger = false;
            //Console.WriteLine(deger);

            Console.ReadLine();
        }


    }
}
