using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //new方式启动
            //Task task = new Task(() =>
            //            {
            //                Console.WriteLine("我是工作线程： tid={0}", Thread.CurrentThread.ManagedThreadId);
            //            });

            //task.Start();

            //使用TaskFactory启动
            //var task = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("我是工作线程： tid={0}", Thread.CurrentThread.ManagedThreadId);
            //});

            //使用Task的Run方法
            //var task = Task.Run(() =>
            //{
            //    Console.WriteLine("我是工作线程： tid={0}", Thread.CurrentThread.ManagedThreadId);
            //});

            //这个是同步执行。。。。也就是阻塞执行。。。
            //var task = new Task(() =>
            //{
            //    System.Threading.Thread.Sleep(1000);
            //    Console.WriteLine("我是工作线程： tid={0}", Thread.CurrentThread.ManagedThreadId);
            //});

            //task.RunSynchronously();

            //Console.WriteLine("我是主线程");

            //Task<TResult>
            var task = new Task<string>(() =>
            {
                return "hello world!!!";
            });

            task.Start();

            var msg = task.Result;

            Console.WriteLine(msg);

            Console.Read();
        }
    }
}
