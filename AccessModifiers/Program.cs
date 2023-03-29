using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // ERİŞİM BİLDİRGEÇLERİ
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    // Private değişkenler tanımlandığı blok içerisinde geçerlidir.
    // Protected, private'in tüm özelliklerini kapsar.
    // Protected neredeyse bir class, bir inheritance özelliği gösterir ve diğer bloklar içerisinde de kullanılabilir.

    class Customer
    {
        private int İd;
        // private default olduğundan yazılmasada olur.
        public void Custom() 
        {
            // class içine private yazılınca, class içindeki tüm bloklarda çağırılabilir. 
            // Ama diğer class larda çağırıldığında gelmez.
            İd= 1;
        }
    }
    class Student : Customer
    {
        protected string Name { get; set; }
        // protected inheritance alan yerde de geçerlidir.
        public Student()
        {
            
        }
    }

    internal class Course
    {
        // internal default değerdir.
        // internal proje içerisinde istenilen noktada çağıralabileceği anlamına gelir.
        public string Adress { get; set; }

        // Üst classlar private ve protected olamaz. İnternal ve Public olabilir.
        // İç içe classlar private ve protected olabilir.
        private class NestedClass
        {

        }
    }
    public class Manager
    {
        public string Departmant{ get; set; } 

        // public diğer projelere çağırılabilmesini sağlar.
        // Bu örnekte AccessModifiersReferance de çağrılmıştır.
    }
}
