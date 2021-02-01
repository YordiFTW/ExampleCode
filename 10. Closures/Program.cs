using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Closures
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            a(); 
            a(); 
            a();

        }
        static Action GiveMeAction()
        {
            Action ret = null;
            int i = 0;
            ret += () =>
            {
                Console.WriteLine("First Method" + i++);
                i++;
            };
            ret += () => 
            {
                Console.WriteLine("Second Method" + i++);
                i++;
            };
            return ret;
        }
    }
}
