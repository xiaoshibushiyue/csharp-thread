using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                Thread.Sleep(100000000);
                Console.WriteLine("子线程执行结束");
            }));

            t.Start();

            t.Join();  //调用线程等待子线程执行完之后才执行。。。 【在此处等待子线程执行完】

            Console.WriteLine("主线程执行完毕");

            Console.Read();
        }
    }
}
