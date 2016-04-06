using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            // New instance (copy of the class)..
            NewTamagotchi t1 = new NewTamagotchi("Lightning", "Male", 100, 100);  
            
            while (t1.GetFullness() > 0 && t1.GetHappiness() > 0)
            {
                Console.WriteLine("Would you want to feed or pet {0}?", t1.GetName());
                string action = Console.ReadLine();

                // Makes user reponse not case-sensitive..
                action = action.ToUpper();
                action = action.ToLower();

                if (action == "pet")
                {
                    Console.WriteLine("You have petted {0}",  t1.GetName() + " " + t1.GetHappiness());
                }
                else if (action == "feed")
                {
                    Console.WriteLine("You have just fed {0}",  t1.GetName() + " " + t1.GetFullness());
                }
                else
                {
                    Console.WriteLine("Either feed or pet {0}", t1.GetName());
                }

                t1.DoStuff();

                if (t1.GetFullness() <= 0 || t1.GetHappiness() <= 0)
                {
                    Console.WriteLine("You have killed {0}", t1.GetName() + " -_- ");
                   
                    // break keyword ends the program..
                    break;
                }
            }
        }
    }
}
