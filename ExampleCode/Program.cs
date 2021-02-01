using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCode
{

    delegate void MeDelegate();
    //class MeDelegate { }

    class Program
    {

        static void Main(string[] args)
        {
            //MeDelegate del = new MeDelegate(Foo);  werkt ook /doet hetzelfde
            //MeDelegate del = Foo;
            //del();

            InvokeTheDelegate(Foo);
            InvokeTheDelegate(Goo);
        }

        static void InvokeTheDelegate(MeDelegate deler)
        {
            deler();
        }

        static void Foo()
        {
            Console.WriteLine("Foo()");
            Console.ReadLine();
        }

        static void Goo()
        {
            Console.WriteLine("Goo()");
            Console.ReadLine();
        }
    }

    
}
