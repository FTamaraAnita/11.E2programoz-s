using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211008
{
    class Program
    {
        static void Main(string[] args)
        {
            //mintafeladat();
            //feladat1();
            feladat2();

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void mintafeladat()
        {
            Console.WriteLine("kávéautomata");
            Console.WriteLine(" A:espresso");
            Console.WriteLine("B:latte machiato");
            Console.WriteLine("C:espresso machiato");
            Console.WriteLine("D:cappucino");
            Console.WriteLine("E:bécsi kávé");
            Console.WriteLine("F:ristretto");
            Console.WriteLine("G:forró csoki");
            Console.WriteLine("válassz egy terméket (A-G) ");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("az espresso ára 130 Ft");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine(" a latte machiato ára 150 Ft");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine(" az espresso machiato ára 140 Ft");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("a cappucino ára 140 Ft");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine(" a bécsi kávé ára 150 Ft");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine(" a ristretto ára 140 Ft");
                    break;
                case 'G':
                case 'g':
                    Console.WriteLine(" a forró csoki ára 150 Ft");
                    break;
                default:
                    Console.WriteLine("nincs ilyen lehetőség");
                    break;
            }
        }
        static void feladat1()
        {
            Console.WriteLine("kérek egy számot 1-12ig");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 1 || szam > 12)
            {

            }

            else
            {
                switch (szam)
                {
                    case 1:
                        Console.WriteLine("Január");
                        break;
                    case 2:
                        Console.WriteLine("Február");
                        break;
                    case 3:
                        Console.WriteLine("Március");
                        break;
                    case 4:
                        Console.WriteLine("Április");
                        break;
                    case 5:
                        Console.WriteLine("Május");
                        break;
                    case 6:
                        Console.WriteLine("Június");
                        break;
                    case 7:
                        Console.WriteLine("Július");
                        break;
                    case 8:
                        Console.WriteLine("augusztus");
                        break;
                    case 9:
                        Console.WriteLine("szeptember");
                        break;
                    case 10:
                        Console.WriteLine("október");
                        break;
                    case 11:
                        Console.WriteLine("november");
                        break;
                    case 12:
                        Console.WriteLine("december");
                        break;
                    default:
                        Console.WriteLine("nem megfelelő a szám");
                        break;
                }
            }

        }
        static void feladat2()
        {
            Console.WriteLine("kérek egy számot 1-12ig");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 1 || szam > 12)
            {
                Console.WriteLine("nem megfelelő a szám");
            }
            else
            {
                
            }



        }
    }
}
