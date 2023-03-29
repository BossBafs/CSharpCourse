using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database1= new Oracle();
            database1.Add();
            database1.Delete();

            Console.ReadLine();

        }
        // Abstract class dır. Interfaces ve Inheritance'ların kullanım amaçlarını bir araya getirir.
        // Abstract'lar new'lenemez(implement).
        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default");
            }
            // Buna tamamlanmış method denir. Burada tüm veri tabanları için tanımlı operasyonlar kodlanır.
            public abstract void Delete();
            // Buna tamamlanmamış method denir. Buradaki operasyonlar tüm veri tabanlarında tanımlı değildir.
            // İçi boş olan virtual methoddur.
            // Ebeveyni tanımlı classlarda tanımlanmamış methodlar çağrılır.
        }
        class SqlServer : Database
        {
            public override void Delete()
            {
                //throw new NotImplementedException();
            }
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Added by Oracle");
            }
        }
    }

}
