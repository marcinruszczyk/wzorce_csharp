using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //utwórzmy dwa obiekto klasy Singleton
            Singleton o1 = Singleton.utworzObiekt();
            Singleton o2 = Singleton.utworzObiekt();

            //sprawdzamy czy referencje wskazują na ten sam obiekt
            if (o1 == o2)
            {
                Console.WriteLine("Identyczne");
            }
            else
            {
                Console.WriteLine("Różne");
            }

        }
    }

    class Singleton
    {
        //tutaj przechowujemy utworzony ewentualnie obiekt
        private static Singleton _obiekt;

        //kontruktor musi byc prywatny lub protected
        //aby uniemożliwić utworzenie obiektu
        //za pomocą operatora new
        private Singleton() { }

        //publiczna metoda statyczna za pomocą której
        //otzymamy referencję do obiektu
        public static Singleton utworzObiekt()
        {
            //sprawdzamy czy już utworzyliśmy instancję klasy
            if (_obiekt == null)
            {
                //jeśli nie to ją tworzymy
                _obiekt = new Singleton();
            }else
            {
                Console.WriteLine("Już istnieje taki obiekt");
            }

            //zwracamy instancję obiektu zapisanego
            //w stacznym polu naszej klasy
            return _obiekt;
        }
    }
}
