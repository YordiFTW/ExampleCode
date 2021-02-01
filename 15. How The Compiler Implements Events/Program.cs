using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.How_The_Compiler_Implements_Events
{
    class Cow
    {
        private Action mooing;
        public event Action Mooing
        {
            add 
            {
                mooing += value;
                mooing += value;
                mooing += value;
                Console.WriteLine("addddding");
            }
            remove 
            {
                mooing -= value;
                Console.WriteLine("removing");
            }
        }

        public void PushSleepingCow()
        {
            if(mooing != null)
            mooing();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow();
            c.Mooing += () => Console.WriteLine("Handler");
            c.PushSleepingCow();
        }
    }
}
