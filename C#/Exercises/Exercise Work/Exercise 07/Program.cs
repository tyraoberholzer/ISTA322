using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oberholzer's Roulette table.");
            Console.WriteLine("To spin the wheel press enter!");
            Console.ReadLine();

            int[] left = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] center = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] right = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] zero = new int[] { 0, 37 };

            int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] red = new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

            Random rndm = new Random();
            int rn = rndm.Next(0, 37);
            Console.WriteLine($"The Roulette ball has landed on......{rn}!!!");

            if (rn == 37)
            {
                Console.WriteLine($"The Rouette ball has landed on..........00");
            }




            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the winners press enter!");
            Console.ReadLine();





            if (rn % 2 == 0)
            {
                Console.WriteLine("Evens WIN!!!");
            }
            else if (rn % 2 != 0)
            {
                Console.WriteLine("Odds WIN!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();


            if (red.Contains(rn))
            {
                Console.WriteLine("Reds WIN!!!");
            }
            else if (black.Contains(rn))
            {
                Console.WriteLine("Blacks WIN!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();



            if (rn <= 18)
            {
                Console.WriteLine("Lows WIN!!!");
            }
            else if (rn >= 19)
            {
                Console.WriteLine("Highs WIN!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();


            if (rn > 0 || rn <= 12)
            {
                Console.WriteLine("1-12 WINS!!!");
            }
            else if (rn > 12 || rn <= 24)
            {
                Console.WriteLine("13-24 WINS!!!");
            }
            else if (rn > 24 || rn <= 36)
            {
                Console.WriteLine("25-36 WINS!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();



            if (left.Contains(rn))
            {
                Console.WriteLine("First Column WINS!!!");
            }
            else if (center.Contains(rn))
            {
                Console.WriteLine("Second Column WINS!!!");
            }
            else if (right.Contains(rn))
            {
                Console.WriteLine("Third Column WINS!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }



            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();




            if (left.Contains(rn))
            {
                Console.WriteLine($"Street winners are................{rn} {rn + 1} {rn + 2}!!!");
            }
            else if (center.Contains(rn))
            {
                Console.WriteLine($"Street winners are................{rn - 1} {rn} {rn + 1}!!!");
            }
            else if (right.Contains(rn))
            {
                Console.WriteLine($"Street winners are................{rn - 2} {rn - 1} {rn}!!!");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();




            if (left.Contains(rn) && rn ==1)
            {
                Console.WriteLine("6 Number Winners............1, 2, 3, 4, 5, 6");
            }
            else if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("6 Number Winners............1, 2, 3, 4, 5, 6");
            }
            else if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("6 Number Winners............1, 2, 3, 4, 5, 6");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("6 Number Winners............31, 32, 33, 34, 35, 36");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("6 Number Winners............31, 32, 33, 34, 35, 36");
            }
            else if (right.Contains(rn) && rn ==36)
            {
                Console.WriteLine("6 Number Winners............31, 32, 33, 34, 35, 36");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"6 Number Winners............{rn}, {rn+1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"6 Number Winners............{rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"6 Number Winners............{rn}, {rn + 1}, {rn + 2}, {rn + 3}, {rn + 4}, {rn + 5}");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }



            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();




            if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn + 1}, {rn + 3}, {rn + 4} or {rn}, {rn - 3}, {rn - 2}, {rn + 1}");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn + 1}, {rn + 3}, {rn + 4}or {rn}, {rn - 1}, {rn + 2}, {rn + 3} or {rn}, {rn - 1}, {rn - 4}, {rn - 3} or {rn}, {rn -3}, {rn -2}, {rn + 1}");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn - 1}, {rn + 2}, {rn + 3} or {rn}, {rn - 1}, {rn - 4}, {rn - 3}");
            }
            else if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn + 1}, {rn + 3}, {rn + 4}");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn -3}, {rn - 2}, {rn + 1}");
            }
            else if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn + 1}, {rn + 3}, {rn + 4} or {rn}, {rn - 1}, {rn + 2}, {rn + 3} ");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn - 1}, {rn - 4}, {rn -3} or {rn}, {rn - 3}, {rn -2}, {rn + 1}");
            }
            else if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn -1}, {rn + 2}, {rn + 3}");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine($"Corner winners are..........{rn}, {rn - 1}, {rn - 4}, {rn - 3}");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }




            Console.WriteLine(" ");
            Console.WriteLine("========================================================================");
            Console.WriteLine("To see the next winners press enter!");
            Console.ReadLine();




            if (left.Contains(rn) && rn == 1)
            {
                Console.WriteLine("Split winners are.........1/2 & 1/4");
            }
            else if (left.Contains(rn) && rn == 34)
            {
                Console.WriteLine("Split winners are.........34/35 & 34/31");
            }
            else if (left.Contains(rn) && rn != 1 && rn != 34)
            {
                Console.WriteLine($"Split winners are.........{rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn + 3}");
            }
            if (center.Contains(rn) && rn == 2)
            {
                Console.WriteLine("Split winners are.........2/1 & 2/3 & 2/5");
            }
            else if (center.Contains(rn) && rn == 35)
            {
                Console.WriteLine("Split winners are.........35/34 & 35/36 & 35/32");
            }
            else if (center.Contains(rn) && rn != 2 && rn != 35)
            {
                Console.WriteLine($"Split winners are.........{rn}/{rn - 3} & {rn}/{rn + 1} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            if (right.Contains(rn) && rn == 3)
            {
                Console.WriteLine("Split winners are.........3/2 & 3/6");
            }
            else if (right.Contains(rn) && rn == 36)
            {
                Console.WriteLine("Split winners are.........36/35 & 36/33");
            }
            else if (right.Contains(rn) && rn != 3 && rn != 36)
            {
                Console.WriteLine($"Split winners are.........{rn}/{rn - 3} & {rn}/{rn - 1} & {rn}/{rn + 3}");
            }
            else if (rn == 0)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else if (rn == 37)
            {
                Console.WriteLine("You LOSE!!!");
            }


        }

    }

}

