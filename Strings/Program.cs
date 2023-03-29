using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        private static void Intro()
        {
            string city = "İzmir";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Aydın";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}",city,city2));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Muhammed Ali TUNÇDEMİR";
                var result = sentence.Length;
                var result2 = sentence.Clone();
            sentence = "My name is Ekrem AKKAYA.";
            Console.WriteLine(result);
            Console.WriteLine(result2);

                bool result3 = sentence.EndsWith("R");
                bool result4 = sentence.StartsWith("My");
            Console.WriteLine(result3);
            Console.WriteLine(result4);

                var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);
                var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine(result6);
            // IndexOf metinin içinde aranın verinin olup olmadığı kontrol eder. 
            // Aranan içeriği bulduğu ilk verinin sayısal değerini verir.
            // LastIndexOf içeriği aramaya sondan başlar.

                var result7 = sentence.Insert(24 ," Good By.");
            Console.WriteLine(result7);
            // İçeriğin istenilen noktasına yeni bir içerik eklemek için kullanılır.
                var result8 = sentence.Substring(3);
            Console.WriteLine(result8);
                var result9 = sentence.Substring(3,4);
            Console.WriteLine(result9);
                var result10 = sentence.Remove(2);
            Console.WriteLine(result10);
                var result11 = sentence.Remove(2,8);
            Console.WriteLine(result11);
            // İçeriğin istenilen noktasından kesmek için kullanılır.
            // İki sınır tanımlanırsa ilk kesilen içerikten sonraki kadar karakterin alınmasını sağlar.
            // Remove ise seçilen kısımdan sonrasını atmak için kullanılır.

                var result12 = sentence.ToLower();
            Console.WriteLine(result12);
                var result13 = sentence.ToUpper();
            Console.WriteLine(result13);
                var result14 = sentence.Replace(" ","--");
            Console.WriteLine(result14);
            // ToLower içeriğin hepsini küçük harfe çevirmeye yarar.
            // ToUpper içeriğin hepsini büyük harfe çevirmeye yarar.
            // Replace içerikte çıkartılmak istenilen içeriğin yerine getirilmesi istenilen içerik eklenir.


            Console.ReadLine();
        }
    }
}
