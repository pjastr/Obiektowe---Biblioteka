using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor
    {
        protected string imie;
        protected string nazwisko;

        public Autor()
        {

        }

        public Autor(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
