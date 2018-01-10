using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Aplikacja
    {
        private static char klawisz;
        private static Katalog katalog = new Katalog("starocie");

        static Aplikacja()
        {
            katalog.Test(); // tu jest dobre miejsce już na wywołanie metody test
        }
        private static void PobierzKlawisz()
        {
            Console.WriteLine("Co chcesz zrobić? Wybierz klawisz i zatwierdź enterem.");
            Console.WriteLine("A - dodaj czasopismo.");
            Console.WriteLine("B - dodaj książkę.");
            Console.WriteLine("C - wyszukaj po tytule.");
            Console.WriteLine("D - wyszukaj po Id.");
            Console.WriteLine("E - pokaż zawartość.");
            Console.WriteLine("X - wyjdź z aplikacji.");

            char[] wybor = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'X', 'x' };
            bool czyPoprawny = false;

            while(!czyPoprawny)
            {
                czyPoprawny = true;
                 try
                 {
                     klawisz = Convert.ToChar(Console.ReadLine());
                 }
                catch(Exception e)
                 {
                     Console.WriteLine(e.Message);
                     czyPoprawny = false;
                 }
                 if (!wybor.Contains(klawisz))
                     czyPoprawny = false;
            }
            Console.Clear();
        }

        public static void WykonajDzialanie()
        {
            while(true)
            {
                PobierzKlawisz();
                
                switch(klawisz)
            {
                case 'a':
                case 'A': katalog.Nowe();Continue();break;

                case 'b':
                case 'B':katalog.Nowa();Continue();break;

                case 'c':
                case 'C':katalog.PodajTytul();Continue();break;

                case 'd':
                case 'D':katalog.PodajId();Continue();break;

                case 'e':
                case 'E':katalog.WypiszWszystko();Continue();break;

                case 'x':
                case 'X': return;
            }
            }
            
        }

        private static void Continue()
        {
            Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();
            Console.Clear();
        }
            
        }

       
    }

