using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NewArrayList();
            //TypeSafeList();
            //TypeSafeListDeneme();
            Dictionary();
            Console.ReadLine();
        }


        private static void Dictionary()
        {
            Dictionary<string,string> dictionary= new Dictionary<string,string>();
            // dictionary (key, value) şeklinde çalışır.
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Tablo");
            dictionary.Add("Computer","Bilgisayar");

            Console.WriteLine(dictionary["Book"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsValue("Tablo"));
        }

        private static void NewArrayList()
        {
            // ArrayList sürekli olarak veri eklemeye olanak tanır.

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İzmir");

            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void TypeSafeList()
        {


            // Tip Güvenli Koleksiyon yalnızca tanımlı operasyon cinsinde veri işler.
            List<string> cities = new List<string>();
            cities.Add("Van");
            cities.Add("Aydın");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirsName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirsName = "Derin" });
            // İki farklı yazım mevcut.



            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirsName = "Engin" },
                new Customer { Id = 2, FirsName = "Derin" }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirsName);
            }
        }

        private static void TypeSafeListDeneme()
        {
            // Koleksiyon Özellik ve Methodları
            List<string> cities = new List<string>();
            cities.Add("Van");
            cities.Add("Aydın");

            //Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Customer[] cst = new Customer[3] {
            //    new Customer { Id = 1, FirsName = "Engin Ar" },
            //    new Customer { Id = 2, FirsName = "Derin Ar" },
            //    new Customer {}
            //};

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirsName = "Engin" },
                new Customer { Id = 2, FirsName = "Derin" }
            };

            var customer2 = new Customer
            {
                Id = 3,
                FirsName = "Muhammed"
            };
            customers.Add(customer2);

            //cst[2] = customer2;

            //foreach (var customer in cst) Console.WriteLine(customer.FirsName);
            //foreach (var customer in customers) Console.WriteLine(customer.FirsName);

            customers.AddRange(new Customer[2] 
            // Array bazlı listeyi methoda eklemeye yarar.
            // Var olan listeye yeni verileri eklemek için kullanılır.
            {
                new Customer { Id = 4, FirsName = "Ekrem"},
                new Customer { Id = 5, FirsName = "Ali"}
            });

            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirsName = "Engin" }));
            Console.WriteLine(customers.Contains(customer2));
            // Aranan değerin olup olmadığını belirler. Bloon cinsinden yanıt verir.
            // İlk değerlendirmede False vermesinin nedeni newlendiğinden (referans edildiğinden) dolayıdır.


            var index = customers.IndexOf(customer2);
            Console.WriteLine("İndex : {0}", index);
            // Listede ki elemanın listenin kaçıncı sırasında olduğunu belirtir.





            customers.Insert(0, customer2);
            // Listenin istenilen sırasına eleman eklemeye yarar.

            customers.Add(customer2);
            var lastindex = customers.LastIndexOf(customer2);
            Console.WriteLine("Lastİndex : {0}", lastindex);
            // Listede ki elemanın listenin sondan kaçıncı sırada olduğunu belirtir.



            //customers.Remove(customer2);
            //customers.RemoveAll(c=>c.FirsName=="Muhammed");
            // Listeden istenilen elemanın çıkarılmasına yarar.


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirsName);
            }

            //customers.Clear();
            // Elemanları temizlemeye yarar.

            var count = customers.Count();
            Console.WriteLine("Count : {0}", count);
            // Eleman sayısını veren özelliktir. Clear özelliği kullanıldığında eleman sayısı temizlendiğinden 0'dır.

        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
    }
}
