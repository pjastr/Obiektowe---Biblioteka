using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanie
    {
        void WypiszWszystko();
        void WyszukajPoTytule(string p1);
        void WyszukajPoId(int p2);
    }
}
