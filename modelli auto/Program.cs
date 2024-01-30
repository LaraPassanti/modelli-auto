using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelli_auto
{
    internal class Program
    {
        static void Main(string[] args)
        { Auto a1 = new Auto();
           a1.modello = "fiat";
            Console.WriteLine("{0}", a1.modello);

            Auto a2 = a1;
            Console.WriteLine("{0}", a2.modello);
            a2.modello = "ferrari";
            Console.WriteLine("{0}", a2.modello);
            
            Auto a3=new Auto();
           
            a3.modello = "dacia";
           Console.WriteLine("{0}", a3.modello);
            a3 = a1;
            Console.WriteLine("{0}", a3.modello);

            Console.ReadLine();
        }
    }
}
