using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MulticastDelegate_vs.Delegate
{

    delegate int MeDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            MeDelegate d = ReturnFive;
            d += ReturnTen;
            d += Return22;

            foreach (int i in GetAllReturnValues(d))
                Console.WriteLine(i);
        }
            static List<int> GetAllReturnValues(MeDelegate d)
        {
            List<int> ints = new List<int>();
            foreach (MeDelegate del in d.GetInvocationList())
                ints.Add(del());
            return ints;
        }

        static int ReturnFive() { return 5; }
        static int ReturnTen() { return 10; }
        static int Return22() { return 22; }
    }
}
