using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Alamprogramm
    {
        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        public static int Korruta()
        {
            Double result = Alamprogramm.Eval(Console.ReadLine());
            int g = 9;
            for (int i = 0; i <= result; i = i + 1)
            {
                Console.Write("mew ");
                if (i == g)
                {
                    g = g + 10;
                    Console.WriteLine("");
                }
            }
            return (int)result;
        }
            static void Main(string[] args)
        {
            Console.WriteLine(Korruta());
            Console.ReadLine();
        }
    }
}
