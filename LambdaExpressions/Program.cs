using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyDelegates
{
    delegate bool MeDelegate(int n);

    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = new[] { 2, 7, 3, 9, 5, 7, 1, 8, 13, 17 };
            IEnumerable<int> result =
                RunNumbersThroughGauntlet(numbers,
                n => n < 5);
            foreach (int n in result)
                Console.WriteLine(n);
        }

        static void Foo() { Console.WriteLine("Foo()"); }

        static IEnumerable<int> RunNumbersThroughGauntlet(
            IEnumerable<int> numbers, MeDelegate gauntlet)
        {
            foreach (int number in numbers)
                if (gauntlet(number))
                    yield return number;
        }
    }
}
