using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DelegateChaining
{

    delegate void MeDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            MeDelegate d = Foo;
            MeDelegate oldD = d;
            d = (MeDelegate)Delegate.Combine(d, new MeDelegate(Goo));
            d += Sue;
            d += Foo;
            d -= Foo;
            foreach (MeDelegate m in d.GetInvocationList())
                Console.WriteLine(m.Target + ": " + d.Method);
            d();
        }

        static void Foo() { Console.WriteLine("Foo()");  }
        static void Goo() { Console.WriteLine("Foo()"); }
        static void Sue() { Console.WriteLine("Foo()"); }
    }
}
