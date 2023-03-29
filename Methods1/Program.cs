using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2,5,9));
            Console.WriteLine(Add4(1,5,4,8,6));
            //Console.WriteLine(result);
            Console.ReadLine();

            // ref yazılan yerdeki değer, değer tanımlı değişkenin değerinin yerini alır.
            // ref yerine out kullanılabilir. Aynı görevi görürler.
            // out da number1=20 şeklinde değer girilmeden (yalnızca number1)tanımlama yapılır.
        }

        static void Add() 
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3 (ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int nume1, int nume2)
        {
            return nume1 * nume2;
        }
        static int Multiply(int nume1, int nume2, int nume3)
        {
            return nume1 * nume2 * nume3;
        }
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
            // .Sum() Toplama yapan hazır method.
            // Tanımlanan ilk değişken, çıktı alınacağı zaman ilk değeri etkisiz kılar.
        }
    }
}
