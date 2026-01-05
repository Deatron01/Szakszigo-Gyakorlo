using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class RendezésesProgramozásiTételek
    {
        // Bemenet: x - T tömb , n - egész (tömb mérete), ahol T összehasonlítható
        // Kimenet: x - T RENDEZETTT tömb
        public static void  MinimumKiválasztásosRendezés<T>(ref T[] x, int n) where T:IComparable<T>
        {
            Console.WriteLine("--- MINIMUMKIVÁLASZTÁSOS RENDEZÉS INDUL ---");
            for (int i = 0; i < n-1; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (0 < x[min].CompareTo(x[j]))
                    {
                        min = j;
                    }
                }
                Console.WriteLine($"Csere: x[{i}] ({x[i]}) <-> x[{min}] ({x[min]})");
                T seged = x[i];
                x[i] = x[min];
                x[min] = seged;
            }
            Console.WriteLine("--- RENDEZÉS VÉGE ---");
        }


        // Bemenet: x - T tömb , n - egész (tömb mérete), ahol T összehasonlítható
        // Kimenet: x - T RENDEZETTT tömb
        public static void JavitottBeillesztesesRendezes<T>(ref T[] x, int n) where T : IComparable<T>
        {
            Console.WriteLine("--- JAVÍTOTT BEILLESZTÉSES RENDEZÉS INDUL ---");
            for (int i = 1; i < n - 1; i++)
            {
                int j = i - 1;
                T seged = x[i];
                while ((j > 0) & (0 < x[j].CompareTo(seged)))
                { 
                    x[j + 1] = x[j];
                    j = j - 1;
                
                }
                x[j + 1] = seged;
            }
            Console.WriteLine("--- RENDEZÉS VÉGE ---");
        }

    }
}
