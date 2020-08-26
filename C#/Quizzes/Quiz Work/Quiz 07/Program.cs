using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Tyra Oberholzer's Quiz 07.");
            IFirearm s = new Shotgun();
            s.doWhat("shotgun", "BOOM");
            IFirearm r = new Rifle();
            r.doWhat("rifle", "BANG");
            IFirearm p = new Pistol();
            p.doWhat("pistol", "POP");
        }
        interface IFirearm
        {
            void doWhat(string what, string action);
        }
        private class Shotgun : IFirearm
        {
            public void doWhat(string what, string action)
            {
                Console.WriteLine($"I am a {what} and I go {action}!");
            }
        }
        private class Rifle : IFirearm
        {
            public void doWhat(string what, string action)
            {
                Console.WriteLine($"I am a {what} and I go {action}!");
            }
        }
        private class Pistol : IFirearm
        {
            public void doWhat(string what, string action)
            {
                Console.WriteLine($"I am a {what} and I go {action}!");
            }
        }
    }
}

//Create an interface IFirearm with one method declaration, a void method that prints a message to console.
//Then instantiate three objects, a Shotgun instance, a Rifle instance, and a Pistol instance that implement the
//interface. Note: You are creating objects of type IFirearm by using the three classes that implement the interface.
//In your main program, instantiate objects, all of type IFirearm.Use the three types Shotgun, Rifle, and Pistol
//to create the three instances.Put your Program class and your other classes in the same le.In other words, use
//the same template we used before except substitute the interface for the class.
//Here is the expected output.
//This is C Sharp quiz 7
//I am a shotgun and I go Boom
//I am a rifle and I go Bang
//I am a pistol and I go Pop
//Press any key to continue . . .