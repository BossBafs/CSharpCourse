namespace Delegates
{

    public delegate void MyDelegate();
    public delegate void MyDelegate1(string text);
    public delegate int MyDelegate2(int number1, int number2);

    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;

            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            myDelegate();

            MyDelegate1 myDelegate1 = customerManager.SendMessage1;
            myDelegate1 += customerManager.ShowAlert1;

            myDelegate1("Hi!");

            Math math = new Math();
            MyDelegate2 myDelegate2 = math.Topla;
            myDelegate2 += math.Carp;

            var sonuc = myDelegate2(2, 3);
            Console.WriteLine(sonuc);



            Func<int, int, int> add = Cıkarma;
            Console.WriteLine(add(7,2));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(10,100);
            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000); // Uygulamayı 1 sn geciktir demek.

            Func<int> getRandomNumber2 = () => new Random().Next(10,100);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }
        static int Cıkarma(int x, int y)
        {
            return x - y;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert() 
        {
            Console.WriteLine("Be Carefull");
        }
        public void ShowAlert1(string alert) 
        {
            Console.WriteLine(alert);
        }
        public void SendMessage1(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Math
    {
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
    
}