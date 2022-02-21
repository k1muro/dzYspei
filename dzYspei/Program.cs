using System;
using System.Threading;

namespace dzYspei
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите любую кнопку когда увидите символы!");

            Thread.Sleep(1000);
            Console.WriteLine("$$$$$$$$$$$$$$$$$");

            DateTime date = DateTime.Now;
            ParameterizedThreadStart param = new ParameterizedThreadStart(Time);
            Thread th = new Thread(param);
            th.Start(date);
        }
        static void Time(object a)
        {
            DateTime date1 = (DateTime)a;
            DateTime date2 = DateTime.Now;
            DateTime date3 = date2;
            Console.ReadKey();
            if (DateTime.Now.Millisecond > date2.Millisecond)
                Console.WriteLine($"{DateTime.Now.Second - date1.Second}.{DateTime.Now.Millisecond - date2.Millisecond}");
            else
                Console.WriteLine($"{DateTime.Now.Second - date1.Second}.{date2.Millisecond - DateTime.Now.Millisecond}");
            Console.ReadLine();
        }
    }
}
