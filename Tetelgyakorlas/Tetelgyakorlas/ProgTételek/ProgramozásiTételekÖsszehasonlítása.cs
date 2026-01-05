using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class ProgramozásiTételekÖsszehasonlítása
    {
        // Bemenet: x - T tömb , n - egész (tömb mérete), f - művelet; ahol T összehasonlítható
        // Kimenet: max - egész, maxérték - T
        public static (int max, TResult maxertek) MasolasMaximumkivalasztas<T, TResult>(T[] x, int n, Func<T, TResult> f) where TResult : IComparable<TResult>
        {
            Console.WriteLine("\n--- MÁSOLÁS ÉS MAXIMUMKIVÁLASZTÁS ÖSSZEÉPÍTÉSE INDUL ---");

            int max = 1;
            TResult maxertek = f(x[0]);

            Console.WriteLine($"Kezdeti állapot: x[0] feldolgozva, maxérték: {maxertek}");
            for (int i = 1; i < n; i++)
            {
                TResult seged = f(x[i]);
                Console.WriteLine($"Vizsgálat: x[{i}] -> f(x) eredménye: {seged}");

                if (maxertek.CompareTo(seged) < 0)
                {
                    Console.WriteLine($"   ÚJ MAXIMUM! {seged} > {maxertek}");
                    max = i;
                    maxertek = seged;
                }
            }
            Console.WriteLine($"Végeredmény: Index: {max}, Számított max érték: {maxertek}");
            return (max, maxertek);
        }



        // Bemenet: x - T tömb , n - egész (tömb mérete), P - Logikai, k - egész
        // Kimenet: van - logikai, idx - egész
        public static (bool van, int idx) MegszamolasKereses<T>(T[] x, int n, Predicate<T> P, int k)
        {
            Console.WriteLine("\n--- MEGSZÁMLÁLÁS ÉS KERESÉS ÖSSZEÉPÍTÉSE INDUL ---");
            int db = 0;
            int i = 0;

            while ((i < n) & (db < k))
            {
                i = i + 1;
                if (P(x[i]))
                {
                    Console.WriteLine($"   Találat ({db}.): x[{i}] = {x[i]}");
                    db = i;
                }

            }
            bool van = (db == k);
            if (van)
            {
                Console.WriteLine($"Siker! A(z) {k}. megfelelő elem indexe: {i}");
                int idx = i;
                return (van, idx);
            }
            else
            {
                Console.WriteLine($"Sikertelen: Csak {db} darab megfelelő elem van a tömbben, a kért {k} helyett.");
                return (van, -1);
            }
        }

        // Bemenet: x - T tömb , n - egész (tömb mérete), ahol T összehasonlítható
        // Kimenet: db - egész, y - egész tömb, maxérték - T
        public static (int db, int[] y, T maxérték) Maxmimumkivalogatas<T>(T[] x, int n) where T : IComparable<T> 
        {
            Console.WriteLine("\n--- MAXIMUM ÉS KIVÁLOGATÁS ÖSSZEÉPÍTÉSE INDUL ---");
            int[] y = new int[n];
            T maxérték = x[1];
            int db = 1;
            y[db] = 1;

            for (int i = 1; i < n; i++)
            {
                if (0 < x[i].CompareTo(maxérték))
                {
                    Console.WriteLine($"   Új maximum! {x[i]} > {maxérték}. Eddigi indexek törölve.");
                    maxérték = x[i];
                    db = 1;
                    y[db] = i;
                }
                else
                {
                    if (x[i].Equals(maxérték))
                    {
                        Console.WriteLine($"   Ismételt maximum: {x[i]} az indexen: {i}");
                        db = db + 1;
                        y[db] = i;
                    }
                }
            }
            Console.WriteLine($"Kész! Maximum: {maxérték}, előfordulások száma: {db}");
            return (db, y, maxérték);
        }

    }
}
