using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class lar tanımlanmış.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            PublicManager publicManager = new PublicManager();
            publicManager.Add();
            publicManager.Update();

            Customer customer = new Customer();
            customer.Id= 1;
            customer.FirstName = "Muhammed Ali";
            customer.LastName = "TUNÇDEMİR";
            customer.City = "Van";
            
            Customer customer2= new Customer 
            { 
                Id= 2, FirstName = "Muhammed Ali", LastName = "TUNÇDEMİR", City = "Van"
            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
