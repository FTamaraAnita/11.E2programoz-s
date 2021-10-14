using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4a();
            //feladat4b();
            //feladat5();
            feladat8();
            Console.ReadLine();
        }
        static void feladat1()
        {
            for (int jfk = 1; jfk < 21; jfk++)
            {
                if (jfk % 1 == 0)
                {
                    Console.WriteLine(jfk + " ");
                }

            }
        }
        static void feladat2()
        {
            for (int jfk = 1; jfk < 21; jfk++)
            {
                if (jfk % 1 == 0)
                {
                    Console.Write(jfk + " ");
                }
            }
        }
        static void feladat3()
        {
            for (int afk = 15; afk < 93; afk++)
            {
                if (afk % 1 == 0)
                {
                    Console.Write(afk + " ");
                }
            }
        }
        static void feladat4a()
        {
            for (int szam = 1; szam < 31; szam++)
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine(szam + " ");
                }

            }
        }
        static void feladat4b()
        {
            for (int szam = 1; szam < 31; szam++)
            {
                if (szam % 2 == 0)
                {
                    Console.Write(szam + " ");
                }
            }
        }
        static void feladat5()
        {
            Console.WriteLine("kérek egy pozitív egész számot");
        }
        static void feladat8()
        {
            for (int szam = 100; szam<401; szam++)
            {
                if (szam /4 ==0)
                {
                    Console.WriteLine(szam + " ");
                }
            }
        }

    }
}
