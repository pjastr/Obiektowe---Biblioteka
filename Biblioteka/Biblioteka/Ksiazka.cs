using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka:Pozycja
    {
        int liczbaStron;
        string imie;
        string nazwisko;
        Autor autor;
        

        public Ksiazka()
        {
            
        }

        public Ksiazka(string tytul,int id,string wydawnictwo,int rokWydania,int liczbaStron, string imie,string nazwisko)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(tytul + " " + id + " " + " " + wydawnictwo + " " + rokWydania + " " + liczbaStron+" "+imie+" "+nazwisko);
        }
    }
}
