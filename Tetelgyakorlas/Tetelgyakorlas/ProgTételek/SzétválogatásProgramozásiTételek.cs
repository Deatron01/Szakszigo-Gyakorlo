using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class SzétválogatásProgramozásiTételek
    {

        // Bemenet: x - T tömb , n - egész (tömb mérete), P - logikai
        // Kimenet: y1 - T tömb, db1 - egész, y2 - T tömb, db2 - egész 
        public static (T[] y1, int db1, T[] y2, int db2) Szetvalogatas<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- SZÉTVÁLOGATÁS INDUL ---");
            T[] y1 = new T[n];
            T[] y2 = new T[n];
            int db1 = 0;
            int db2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (P(x[i]))
                {
                    Console.WriteLine($"[+] Megfelel (P): x[{i}] = {x[i]} -> y1[{db1}]-be kerül.");
                    y1[db1] = x[i];
                    db1 = db1 + 1;
                }
                else
                {
                    Console.WriteLine($"[-] NEM felel meg (P): x[{i}] = {x[i]} -> y2[{db2}]-be kerül.");
                    y2[db2] = x[i];
                    db2 = db2 + 1;
                }
            }

            Console.WriteLine($"Szétválogatás kész. 'P' csoport: {db1} db, 'Nem P' csoport: {db2} db.");
            return (y1, db1, y2, db2);
        }

        // Bemenet: x - T tömb , n - egész (tömb mérete), P - logikai
        // Kimenet: y - T tömb, db - egész
        public static (T[] y, int db) SzetvalogatasEgyUjTombe<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- SZÉTVÁLOGATÁS INDUL ---");
            T[] y = new T[n];
            int db = 0;
            int jobb = n;
            for (int i = 0; i < n; i++)
            {
                if (P(x[i]))
                {
                    Console.WriteLine($"[+] Megfelel (P): x[{i}] = {x[i]} -> y[{db}]-be kerül.");
                    y[db] = x[i];
                    db = db + 1;
                }
                else
                {
                    Console.WriteLine($"[-] NEM felel meg (P): x[{i}] = {x[i]} -> y[jobb] = x[i].");
                    jobb = jobb - 1;
                    y[jobb] = x[i];
                }
            }

            Console.WriteLine($"Szétválogatás kész. 'P' csoport: {db} db");
            return (y, db);
        }

    }
}
