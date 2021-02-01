using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.More_Complex_Closures
{
    public class Program
    {


        public static void Main(string[] args)
        {
            Action a = GiveMeAction();
            Action b = GiveMeAction();
            b();
            a();
            a();
            a();
            b();
            a();
        }

        public class Displyaodi
        {
            int i = 5;
           public void sfdoijfd()
            {
                i++;
            }
           public void dfoisj()
            {
                i += 2;
            }
        }

       public static Action GiveMeAction()
        {
            Action ret = null;
            var temp = new Displyaodi();
            ret += temp.sfdoijfd;
            ret += temp.dfoisj;

            return ret;
        }

    }
}