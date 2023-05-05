using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Attribute'ler zorunlu olarak girilmesi gereken entityleri veya classları eşitlemeye çalışmaya yarar.

            Customer customer = new Customer { Id=1, LastName="DEMİROĞ", Age=36};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }
    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    class RequiredPropertyAttribute:Attribute
    {

    }
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}