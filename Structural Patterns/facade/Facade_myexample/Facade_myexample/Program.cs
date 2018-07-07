using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///w  EnergyPermitRejected  WaterPermit() HeatPermit() ProjectAcceptance() 
/// jesli nie wydano pozwolenia ustaw  true
/// /// </summary>

namespace Facade_myexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen c = new Citizen("Marcin");
            House home = new House();
            bool eligible = home.IsEligible(c);
            Console.WriteLine("\n"  + c.Name +" twoje pozwolenie na budowe " + " zostało " + (eligible ? "zatwierdzone." : "odrzucone."));

            // Wait for user
            Console.ReadKey();
        }
    }


    class EnergyPermit
    {
        public bool EnergyPermitRejected()
        {
            Console.WriteLine("Pozwolenia na dostęp do sieci energetycznej sprawdzone.");
            return false;
        }
    }

    class WaterPermit
    {
        public bool WaterPermitRejected()
        {
            Console.WriteLine("Pozolenie na dostęp do sieci wodno-kanalizacyjnej sprawdzone.");
            return false;
        }
    }


    class HeatPermit
    {
        public bool HeatPermitRejected()
        {
            Console.WriteLine("Pozwoleie na dostęp do sieci ciepłowniczej sprawdzone.");
            return false;
        }
    }

    class ProjectAcceptance
    {
        public bool ProjectPermitRejected()
        {
            Console.WriteLine("Projekt architektoniczny przeszedł weryfikację");
            return false;
        }
    }

   
    class Citizen

    {
        private string _name;


        public Citizen(string name)
        {
            this._name = name;
        }


        public string Name
        {
            get { return _name; }
        }
    }



    class House

        {
        private EnergyPermit ep = new EnergyPermit();
        private WaterPermit wp = new WaterPermit();
        private HeatPermit hp = new HeatPermit();
        private ProjectAcceptance pa = new ProjectAcceptance();


        public bool IsEligible(Citizen c)
        {
            Console.WriteLine("Obywatel aplikuje o pozwolnia na budowe domu:\n");

            bool eligible = true;

            
            if (hp.HeatPermitRejected())
            {
                eligible = false;
            }
            else if (wp.WaterPermitRejected())
            {
                eligible = false;
            }
            else if (ep.EnergyPermitRejected())
            {
                eligible =false;
            }
            else if (pa.ProjectPermitRejected())
            {
                eligible = false;
            }

            return eligible;
        }
      }


    }
