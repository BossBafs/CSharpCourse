using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class VirtualMethods
    {
        static void Main1(string[] args)
        {
            //SqlServer sqlServers = new SqlServer();
            //sqlServers.Add();
            //MySql mySql = new MySql();
            //mySql.Deleted();
        }

    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Database");
        }
        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by Database");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer");
            // Bu ise Database den gelen kodu ezmek için kullanılır.
            // base.Add(); Bu tanımlı olarak yazdırmak için gelir.
            // Kodu ezmek istemezsek ve ikisini de yazdırmak istersek, ikisi birden de yazılabilir.
        }
    }
    class MySql : Database
    {

    }
}

