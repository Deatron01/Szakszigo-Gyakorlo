using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class BináriskeresésIteratívésRekurzívVáltozataProgramozásiTételek
    {
        // Bemenet: x - T RENDEZETT tömb , n - egész (tömb mérete), érték - T, ahol T összehasonlítható
        // Kimenet: van - logikai, idx - egész 
        public static (bool van, int idx) LogaritmikusKereses<T>(T[] x, int n, T ertek) where T : IComparable<T> 
        {
            Console.WriteLine("\n--- LOGARITMIKUS KERESES INDUL ---");
            int bal = 1;
            int jobb = n;
            int center = (bal + jobb) / 2;
            while((bal < jobb) & (!x[center].Equals(ertek)))
            {
                if (0 < x[center].CompareTo(ertek))
                {
                    jobb = center - 1;

                }
                else
                {
                    bal = center + 1;
                }
                center = (bal + jobb) / 2;
            }
            bool van = bal<= jobb;
            if (van)
            {
                int idx = center;
                return (van, idx);
            }
            else
            {
                return (van, -1);
            }
        }

        // Bemenet: x - T RENDEZETT tömb , bal - egész, jobb - egész, érték - T, ahol T összehasonlítható
        // Kimenet: Az értékekkel megegyező elem indexe, illetve ha nincs, akkor 0 
        public static int LogaritmikusKeresesRekurziv<T>(T[] x, int bal, int jobb, T ertek) where T : IComparable<T>
        {
            Console.WriteLine("\n--- LOGARITMIKUS REKURZIV KERESES INDUL EZEKKEL AZ ÉRTÉKEKKEL ---");
            Console.WriteLine($"bal : {bal} , jobb: {jobb} , keresett érték : {ertek}");
            
            if ( bal > jobb)
            {
                return 0;
            }
            else
            {
                int center = (bal + jobb) / 2;
                if (x[center].Equals(ertek))
                {
                    return center;
                }
                else
                {
                    if ( 0 < x[center].CompareTo(ertek))
                    {
                        return LogaritmikusKeresesRekurziv(x, bal, center - 1, ertek);
                    }
                    else
                    {
                        return LogaritmikusKeresesRekurziv(x, center+1, jobb, ertek);
                    }
                }
            }

        }
    }
}
