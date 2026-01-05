using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class KiválogatásProgramozásiTételek
    {
        // Bemenet: x - T tömb , n - egész (tömb mérete), P - logikai
        // Kimenet: y - T tömb, db - egész
        public static List<T> Kivalogatas<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- KIVÁLOGATÁS (Új listába) INDUL ---");
            List<T> y = new List<T>();
            int db = 0;

            for (int i = 0; i < n; i++)
            {
                if (P(x[i]))
                {
                    db = db + 1;
                    y.Add(x[i]);
                    Console.WriteLine($"Találat! x[{i}] = {x[i]} bekerült az y listába. (Eddig {db} db)");
                }
                else
                {
                    Console.WriteLine($"x[{i}] = {x[i]} nem felel meg a feltételnek.");
                }
            }

            Console.WriteLine($"Kiválogatás vége. Összesen {db} elemet válogattunk ki.");
            return y;
        }


        // Bemenet: x - T tömb , n - egész (tömb mérete), P - logikai
        // Kimenet: x - T tömb (helyben módosítva), db - egész
        public static int KivalogatasEredetiTomben<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- KIVÁLOGATÁS (Eredeti tömbben/Helyben) INDUL ---");
            int db = 0; // Megjegyzés: a C# 0-tól indexel, így a 'db' lesz az új index is

            for (int i = 0; i < n; i++)
            {
                if (P(x[i]))
                {
                    // Fontos: Előbb használjuk a db-t indexnek, utána növeljük, 
                    // vagy ha a tétel szerinti 'db' darabszámot akarjuk indexnek, akkor x[db] = x[i] után db++.
                    Console.WriteLine($"Megfelelő elem: x[{i}] ({x[i]}). Áthelyezés az x[{db}] pozícióba.");

                    x[db] = x[i];
                    db = db + 1;
                }
                else
                {
                    Console.WriteLine($"x[{i}] ({x[i]}) kimarad.");
                }
            }

            Console.WriteLine($"Helyben kiválogatás vége. Az első {db} elem reprezentálja a végeredményt.");
            return db;
        }
    }
}