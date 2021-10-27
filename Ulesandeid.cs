using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Ulesandeid
    {
        public static void Main(string[] args)

        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n1 - Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid\n2 - Küsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala\n3 - Leia 30% hinnasoodustusega hinna põhjal alghind ");
                int chose = int.Parse(Console.ReadLine());
                if (chose == 1)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------ \nKüsi kahe inimese nimed ning teata, et nad on täna pinginaabrid  \nName1");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Name2");
                    string name2 = Console.ReadLine();
                    if (name1.ToLower() == "oleg" && name2.ToLower() == "igor" || name2.ToLower() == "oleg" && name1.ToLower() == "igor")
                    {
                        Console.WriteLine(name1 + " Right next to " + name2);
                    }
                }
                else if (chose == 2)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------ \nKüsi ristkülikukujulise toa seinte pikkused ning arvuta põranda pindala \narv1");
                    int a = Math.Abs(int.Parse(Console.ReadLine()));
                    Console.WriteLine("arv2:");
                    int b = Math.Abs(int.Parse(Console.ReadLine()));
                    Console.WriteLine("S = {0}", a * b);
                    Console.WriteLine("Do you want to make renovation?");
                    if (Console.ReadLine() == "yes")
                    {
                        Console.WriteLine("How much it cost for metr?");
                        decimal hind = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Round(hind * ((a / 100) * (b / 100)), 2) + "- summa");
                    }
                }
                else if (chose == 3)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------ \nLeia 30% hinnasoodustusega hinna põhjal alghind \narv1");
                    int arv = int.Parse(Console.ReadLine());
                    if (arv > 0)
                    {
                        int procent = (arv * 30 / 100);
                        Console.WriteLine("S = {0}", arv - procent);
                    }
                }
                else if (chose == 4)
                {
                    Console.WriteLine("");
                    decimal temp = decimal.Parse(Console.ReadLine());
                    if (temp < 18)
                    {
                        Console.WriteLine("big");
                    }
                    else if (temp > 18)
                    {
                        Console.WriteLine("small");
                    }
                    else if (temp == 18)
                    {
                        Console.WriteLine("normal");
                    }
                }
                else if (chose == 5)
                {
                    int mult = 1;
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Please enter a number N{i + 1}\n>");
                        int smt = Convert.ToInt32(Console.ReadLine());
                        sum += smt;
                        mult = smt * mult;
                    }
                    double avg = sum / 5;
                    Console.WriteLine($"\nNums AVG = {avg}\nNums Sum = {sum }\nNums multiplied = {mult}");
                }
                else if (chose == 6)
                {
                    string elephant = "1";
                    while (elephant != "elephant")
                    {
                        Console.Write("Please buy a elephant(write elephant)\n>");
                        elephant = Console.ReadLine();
                    }
                }
                else if (chose == 7)
                {

                for (int I = 1; I <= 10; I = I + 1) 
                {
                    for (int i = 1*10*I-10; i <= 10*I; i = i + 1) 
                    {
                        Console.Write(i+" ");
                    }
                    Console.Write("\n");
                }
                }
                else if (chose == 8)
                {
                    int arv;
                    int[] arvud= new  int[4];
                    for(int i =0; i <4;i++){
                        Console.WriteLine("Sisesta{0} arv:", i+1);
                        arv = int.Parse(Console.ReadLine());
                        arvud[i] = arv;
                    }
                    Array.Sort(arvud);
                    foreach(var a in arvud)
                    {
                        Console.WriteLine(a);
                    }
                    int arv4=0;
                    Array.Reverse(arvud);
                    foreach(var a in arvud)
                    {
                        arv4=arv4*10+a;
                    }
                    Console.Write(arv4);
                }






                else if (chose == 11)
                {            
                for (int I = 1; I <= 10; I = I + 1) 
                {
                    for (int i = 1; i <= 10; i = i + 1) 
                    {
                        Console.Write(I*i+" ");
                    }
                    Console.Write("\n");
                }
                }














                else
                {
                    exit = false;
                    Console.WriteLine("Prog exit");
                }

            }

                Console.ReadLine();

        }
    }
}
