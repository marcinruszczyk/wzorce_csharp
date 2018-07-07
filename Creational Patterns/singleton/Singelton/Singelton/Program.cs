using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Structural
{
    //Ensure a class has only one instance and provide a global point of access to it.

    class MainApp

    {
        

        static void Main()
        {
            // Constructor is protected -- cannot use new

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user

            Console.ReadKey();
        }
    }

   

    class Singleton

    {
        private static Singleton _instance;

        // Constructor is 'protected'

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            
            if (_instance == null)
            {
                _instance = new Singleton();
               
            }

            return _instance;
        }
    }
}