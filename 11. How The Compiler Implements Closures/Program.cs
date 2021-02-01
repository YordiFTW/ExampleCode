using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.How_The_Compiler_Implements_Closures
{
    class Program
    {

        class DisplayClass
        {
            public int i;
            public void theMethodGeneratedFromTheLambdaExpression()
            {
                i++;
            }
        }

        static void Main(string[] args)
        {
            Action a = GiveMeAction();
            a();
            Action b = GiveMeAction();
            b();
            a();
            b();
            a();
        }
        static Action GiveMeAction()
        {
            return new Action(new DisplayClass().theMethodGeneratedFromTheLambdaExpression);
        }

    }
}
