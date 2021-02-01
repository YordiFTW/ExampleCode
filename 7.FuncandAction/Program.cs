using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MulticastDelegate_vs.Delegate
{

    delegate T MeDelegate<T>();

    class Program
    {
        static void Main(string[] args)
        {
            Func<int> d = ReturnFive;
            d += ReturnTen;
            d += Return22;
            Func<int, string, bool> f = TakeAnIntAndAStringAndReturnABool;
            Action<string> a = TakeAStringAndReturnVoid;
            foreach (int i in GetAllReturnValues(d))
                Console.WriteLine(i);
        }
        static void TakeAStringAndReturnVoid(string s) { }
        static bool TakeAnIntAndAStringAndReturnABool(int i, string s) { return false; }
        static IEnumerable<Targ> 
            GetAllReturnValues<Targ>(Func<Targ> d)
        {
            foreach (MeDelegate<Targ> del in d.GetInvocationList())
                yield return del();
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int Return22() { return 22; }
    }
}
