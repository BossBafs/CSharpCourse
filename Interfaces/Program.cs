using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interfacesler new'lenmez(implement).

            //InterfacesIntro();
            //Demo();

            InterfaceDemo ınterfaceDemo = new InterfaceDemo();
            

            ICustomerDal[] customerDals = new ICustomerDal[2]
            { 
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Deleted();
            }

            Console.ReadLine();
        } 

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
        
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            { 
                Id = 1,
                FirstName = "Muhammed Ali",
                LastName = "TUNÇDEMİR",
                Address = "Van"
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Ekrem",
                LastName = "AKKAYA",
                Departmant = "Software"
            };
            manager.Add(customer);
            manager.Add(student);
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

            // interface soyut bir class'dır. 
            // Burada yazılan operasyonlar (Özellik veya Method) somut classlarda tanımlanırsa kolayca çağırılır.
            // Soyut oprerasyonlar new'lenemez. Örn; IPerson manager = new IPerson();

        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
