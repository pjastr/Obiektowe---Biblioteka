using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog:IZarzadzanie
    {
        string dzialTematyczny;
        public string DzialTematyczny
        {
            get { return dzialTematyczny; }
            set { dzialTematyczny = value; }
        }
         static List<Pozycja> pozycje=new List<Pozycja>();

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        
        public static void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            pozycje.Add(new Czasopismo(tytul, id, wydawnictwo, rokWydania, numer));
        }

        public static void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron,string imie,string nazwisko)
        {
            pozycje.Add(new Ksiazka (tytul, id, wydawnictwo, rokWydania,liczbaStron,imie,nazwisko));
        }
        
        public void Nowe()
        {
            string  tytul, wydawnictwo;
            int id=-1;
            int rokWydania = -1;
            int numer=-1;
            bool czyPoprawna = false;

            Console.WriteLine("Podaj tytul:");
            tytul = Console.ReadLine();
            Console.Write("Podaj numer identyfikacyjny: ");
            while (!czyPoprawna)
            {
                czyPoprawna = true;
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }

            Console.WriteLine("Podaj nazwę wydawnictwa.");
            wydawnictwo = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania: ");
            czyPoprawna = false;
            while (!czyPoprawna)
            {
                czyPoprawna = true;
                try
                {
                    rokWydania = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }
             Console.WriteLine("Podaj numer czasopisma.");
             czyPoprawna = false;
             while (!czyPoprawna)
                {

                    czyPoprawna = true;
                    try
                    {
                        numer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        czyPoprawna = false;
                    }
                }
            
            DodajPozycje(tytul, id, wydawnictwo, rokWydania, numer); 
        }

        public void Nowa()
        {
            string tytul, wydawnictwo,imie,nazwisko;
            int id=-1;
            int rokWydania = -1;
            int liczbaStron=-1;
            bool czyPoprawna = false;

            Console.WriteLine("Podaj tytul:");
            tytul = Console.ReadLine();
            Console.Write("Podaj numer identyfikacyjny: ");
            while (!czyPoprawna)
            {
                czyPoprawna = true;
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }

            Console.WriteLine("Podaj nazwę wydawnictwa.");
            wydawnictwo = Console.ReadLine();
            Console.Write("Podaj rok wydania: ");
            czyPoprawna = false;
            while (!czyPoprawna)
            {
                czyPoprawna = true;
                try
                {
                    rokWydania = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }
            Console.WriteLine("Podaj liczbę stron.");
            czyPoprawna = false;
            while (!czyPoprawna)
            {

                czyPoprawna = true;
                try
                {
                    liczbaStron = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }

            Console.WriteLine("Podaj imię autora.");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko autora.");
            nazwisko = Console.ReadLine();
            

            DodajPozycje(tytul, id, wydawnictwo, rokWydania, liczbaStron,imie,nazwisko);
        }

        
        public void WypiszWszystko()
        {
            for (int i = 0; i < pozycje.Count;i++ )
            {
                pozycje[i].WypiszInfo();
            }
        }

        public void PodajTytul()
        {
            string tytul;
            Console.WriteLine("Podaj tytul, a ja poszukam pozycji.");
            tytul = Console.ReadLine();
            WyszukajPoTytule(tytul);

        }

        public void WyszukajPoTytule(string tytul)
        {
            for(int i=0;i<pozycje.Count;i++)
            {
                if (tytul == pozycje[i].PobierzTytul()) 
                    pozycje[i].WypiszInfo();
            }
        }

        public void PodajId()
        {
            int id=-1;
            Console.WriteLine("Podaj Id, a ja wyszukam pozycje.");
            bool czyPoprawna = false;
            while (!czyPoprawna)
            {
                czyPoprawna = true;
                try
                {
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    czyPoprawna = false;
                }
            }
            WyszukajPoId(id);
        }
        
        public void WyszukajPoId(int id)
        {
            for (int i = 0; i < pozycje.Count; i++)
            {
                if (id == pozycje[i].PobierzId())
                    pozycje[i].WypiszInfo();
            }

        }

        public void Test()
        {
            DodajPozycje("Gazeta Olsztyńska", 200, "Edytor", 1992, 7);
            DodajPozycje("Gazeta Wyborcza", 123, "Agora", 2010, 23);
            DodajPozycje("Krzyżacy", 220, "Znak", 2010,300,"Henryk","Sienkiewicz");
            DodajPozycje("Krzyżacy", 221, "Znak", 2011,298, "Henryk", "Sienkiewicz");
        }
    }
}
