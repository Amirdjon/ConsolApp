using System;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Test_App
{
    class Program
    {
        static int A;
        struct Amirstruct
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal d;
            public decimal e;
            public decimal f;
            public decimal g;
            public decimal h;
            public decimal i;
        }

        static void Foo(Amirstruct value)
        {

        }
        static void Foo1(in Amirstruct value)
        {

        }


        static void Main(string[] args)
        {
            Amirstruct A = new Amirstruct();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(A);
            }
            sw.Stop();

            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");
            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo1(A);
            }
            sw.Stop();
            Console.WriteLine($"Foo1 {sw.ElapsedMilliseconds}");

            //sw.Stop();
            //Console.WriteLine($"Время работи прога: {sw.ElapsedMilliseconds}");
            //Console.ReadLine();
        }
    }
}
