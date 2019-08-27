using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0604A1Lottozahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[6];
            int anzahl = 0, zuf = 0;
            Random zufall = new Random();
            Boolean found = false;

            do
            {
                zuf = zufall.Next(1, 50);
                found = false;
                for (int i = 0; i < 6; i++)
                    if (zahlen[i] == zuf)
                    {
                        found = true;
                        break;
                    }
                if (!found)
                {
                    zahlen[anzahl] = zuf;
                    anzahl++;
                }
            } while (anzahl < 6);

            foreach (int a in zahlen)
                Console.Write("{0} ", a);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
