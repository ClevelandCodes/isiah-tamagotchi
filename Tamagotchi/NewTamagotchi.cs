using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class NewTamagotchi
    {
        // Declare variables and make them private..
        private string Name = "N/A";
        private string Gender = "N/A";
        private int Fullness = 0;
        private int Happiness = 0;

        // Constructor - a blueprint to follow..
        public NewTamagotchi(string name, string gender, int fullness, int happines)
        {
            // Assign to private attribute, lowercase variables can be anything you want and they are just variable names..
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happines;
        }
        // Getter methods (functions) - used to drag the private attributes into the public..
        public string GetName()
        {
            return Name;
        }

        public string GetGender()
        {
            return Gender;
        }

        public int GetFullness()
        {
            return Fullness;
        }

        public int GetHappiness()
        {
            return Happiness;
        }

        public int Pet()
        {
            Happiness = Happiness + 1;
            return Happiness;
        }

        public int Feed()
        {
            Fullness = Fullness + 1;
            return Fullness;
        }
   
        // Void: does not return any value when the method is called..
        public void DoStuff()
        {
            // Initializes a new instance of the Random class, using a time-dependent default seed value, Represents a pseudo-random number generator..
            Random rnd = new Random();
            // Same as  Happiness = Happiness - rnd.Next(10)..
            // rnd.Next(10) - max number to be decremented by..
            Happiness -= rnd.Next(10);
            // Same as  Fullness = Fullness - rnd.Next(10)..
            // rnd.Nect(10) can also hold two values.. Ex: rnd.Next(1, 10) with 1 being the minimum number and 10 being the max number
            Fullness -= rnd.Next(10);
        }
    }
}
