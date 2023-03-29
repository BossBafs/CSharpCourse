using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServers = new SqlServer();
            sqlServers.Add();
            MySql mySql = new MySql();
            mySql.Deleted();
            Person[] persons = new Person[2]
            {
                new Customer
                {
                    Name = "Muhammed Ali"
                },
                new Student
                {
                    Name = "Ekrem"
                },
            };
            
            foreach (var person in persons) 
            { 
                Console.WriteLine(person.Name);   
            }
            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

        }
        // Person burada Customer ve Student'in ebeveynidir. 
        // Her class a yalnızca bir ebeveyn(Inheritance) atanır.
        // Fakat ebeveyn olarak Interface atanırsa; birden fazla atanabilir.
        // Ebeveynde yazılan operasyonlar, çağırılan class larda tanımlı olur, yazılmaya gerek kalmaz.
        class Customer : Person
        {
            public string Call { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
