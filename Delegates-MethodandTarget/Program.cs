using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_MethodandTarget
{

    delegate void MeDelegate(int value);

    class Program
    {
        static void Main(string[] args)
        {
            MeDelegate d = Foo;
            Console.WriteLine(d.Method);
            Console.WriteLine(d.Target);
            Program m = new Program();
            d = m.Goo;
            Console.WriteLine(d.Method);
            Console.WriteLine(d.Target);
            Console.ReadLine();
        }


        static void Foo(int u) { }

        void Goo(int asdf) { }


    }
}
