using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1()
            feladat2();
        }
       
        static void feladat1()
         {
            Console.WriteLine("adj meg egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("páros a szám");
            }
            else
            {
                Console.WriteLine("páratlan a szám");
            }
            Console.Read();

         }
        static void feladat2()
        {
            Console.WriteLine("kérek egy számot");
            int elojel = Convert.ToInt32(Console.ReadLine());
            if (elojel > 0)
            {
                Console.Write("pozitív szám");

            }
            else
            {
                Console.Write("negatív a szám");
            }
            Console.Read();
        }

    }
}
