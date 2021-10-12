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
            feladat3();
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
            for (int afk=15; afk <93; afk++)
            {
                if (afk % 1==0)
                {
                    Console.Write(afk + " ");
                }
            }
        }
    }
}
