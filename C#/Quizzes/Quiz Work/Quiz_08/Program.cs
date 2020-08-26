using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Tyra Oberholzer's C# Quiz 08.");
            Console.WriteLine(" ");
            Console.WriteLine("========================================================================================================");


            firearm pistol = new firearm("Pistol", "POP", "9mm");
            Console.WriteLine(pistol.ToString());

            firearm rifle = new firearm("Rifle", "BANG", "7.62 mm");
            Console.WriteLine(rifle.ToString());

            firearm shotgun = new firearm("Shotgun", "BOOM", "12 Gauge");
            Console.WriteLine(shotgun.ToString());

        }
    }
    class firearm
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string Caliper { get; set; }
        static int count = 0;

        public firearm(string name, string sound, string  caliper)
        {
            Name = name;
            Sound = sound;
            Caliper = caliper;
            count++;
        }

        public override string ToString()
        {
            string s = ($"I am a {Name}, and I go {Sound}! We have {count} firearms.");
            return s;
        }
    }
}

//I am a pistol, and I go pop with a 9 mm round, and we have 1 firearms
//I am a rifle, and I go bang with a 7.62 mm round, and we have 2 firearms
//I am a shotgun, and I go bang with a 12 gauge round, and we have 3 firearms
//Press any key to continue . . .
//Page 1,

//Do not create separate files for your class, but place your program and class in the same le as we did before.
//You will create a Firearm class with three automatic properties: Name, Sound, and Caliber.Also, create a class
//property of type int that increments the count of rearms as they are created.Write an appropriate constructor
//and a ToString() method.


//In your Program class, instantiate three objects, a rifle,
// a shsotgun, and a pistol and print them.Do not manually
//increment the count but have it implemented programatically.Put both the program class and your object class in
//the same file as we have done before.

