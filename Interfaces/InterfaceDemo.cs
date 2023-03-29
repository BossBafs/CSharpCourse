using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class InterfaceDemo
    {
        IWorker[] workers = new IWorker[3] { new Worker(), new Manager(), new Robot() };
        IEat[] eats = new IEat[2] { new Worker(), new Manager() };

        public InterfaceDemo()
        {
            Func();
            Func1();
        }

        void Func()
        {
            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
        void Func1()
        {
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }

    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Im working!");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Im working!");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Im working!");
        }
    }
}
