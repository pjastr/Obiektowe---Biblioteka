using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        private static Katalog test = new Katalog("nowości");
        static void Main(string[] args)
        {
            test.Test();
            test.WypiszWszystko();
            Console.ReadKey();
            Aplikacja.WykonajDzialanie();
            
        }
    }
}
