using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        // Dal = "Data Access Layer"/"Veri Erişim Katmanı". Add, Update, Delete ...vb gibi işlemleri yapmada kulanılır.
        void Added();
        void Updated();
        void Deleted();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Added()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Deleted()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Updated()
        {
            Console.WriteLine("Sql Updated!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Added()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Deleted()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Updated()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Added();
        }
    }
}
