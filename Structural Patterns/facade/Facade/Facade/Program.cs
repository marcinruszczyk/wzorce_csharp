using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Wzorzec pokazuje jak w  jednej  klasie zebrać  zestaw  klas  składajacych się na podsystemgit status
/// 
/// </summary>



namespace DesignPatterns.Facade.Structural
{
    

    class MainApp

    {
        

        public static void Main()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            //nowa facade
            facade.MethodC();

            
            Console.ReadKey();
        }
    }

    

    class SubSystemOne

    {
        public void MethodOne()
        {
            Console.WriteLine(" SubSystemOne Method");
        }
    }

    

    class SubSystemTwo

    {
        public void MethodTwo()
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
    }

   

    class SubSystemThree

    {
        public void MethodThree()
        {
            Console.WriteLine(" SubSystemThree Method");
        }
    }

    

    class SubSystemFour

    {
        public void MethodFour()
        {
            Console.WriteLine(" SubSystemFour Method");
        }
    }

    

    class Facade

    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _two.MethodTwo();
            _three.MethodThree();
        }


        public void MethodC()
        {
            Console.WriteLine("\nMethodC() ---- ");
            _three.MethodThree();

        }

    }
}

