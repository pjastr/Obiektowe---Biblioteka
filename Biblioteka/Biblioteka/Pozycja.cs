using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja()
        {

        }
        
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        abstract public void WypiszInfo();
        
        public string PobierzTytul()
        {
            return tytul;
        }

        public int PobierzId()
        {
            return id;
        }
    }
}
