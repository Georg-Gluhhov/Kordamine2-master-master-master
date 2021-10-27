using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            Console.WriteLine("\n How old are you?");
            int age = int.Parse(Console.ReadLine());



            if (eesnimi.ToLower() == "oleg")
            {
                Console.WriteLine("\n Tule minu juurde külla! " + eesnimi);
                if (age <= 6)
                {
                    Console.WriteLine("tahuta");
                }
                else if (age > 6 && age <= 14)
                {
                    Console.WriteLine("tastepillet");
                }
                else if (age >= 15 && age <= 65)
                {
                    Console.WriteLine("tainpilet");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("rooduspilet");
                }

            }
            else
            {
                Console.WriteLine("\n Tule mind kodus pole! " + eesnimi);
            }

            Console.WriteLine("\n Numbers \n arv1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("arv2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1}  korrutis võrdub {2}", a, b, a * b);



            Console.ReadLine();
        }
    }
}
