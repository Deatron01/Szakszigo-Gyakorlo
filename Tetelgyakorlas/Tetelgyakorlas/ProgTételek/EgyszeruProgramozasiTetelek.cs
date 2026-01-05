using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class EgyszeruProgramozasiTetelek
    {
        // Eldöntés tétel naplózással
        public static bool Eldontes<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- ELDÖNTÉS INDUL ---");
            int i = 0;
            while (i < n & !P(x[i]))
            {
                Console.WriteLine($"Vizsgálat: x[{i}] = {x[i]} -> NEM felel meg.");
                i = i + 1;
            }

            bool van = i < n;
            if (van) Console.WriteLine($"Találat! Az első megfelelő elem: x[{i}] = {x[i]}");
            else Console.WriteLine("Nincs a feltételnek megfelelő elem a tömbben.");

            return van;
        }

        // Lineáris keresés naplózással
        public string[] LinearisKereses<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- LINEÁRIS KERESÉS INDUL ---");
            int i = 0;
            while (i < n & !P(x[i]))
            {
                Console.WriteLine($"Keresés folyamatban... x[{i}] = {x[i]}");
                i = i + 1;
            }

            bool van = i < n;
            string[] eredmeny;
            if (van)
            {
                Console.WriteLine($"Sikeres keresés! Index: {i}");
                eredmeny = new string[2];
                eredmeny[0] = van.ToString();
                eredmeny[1] = i.ToString();
            }
            else
            {
                Console.WriteLine("Sikertelen keresés.");
                eredmeny = new string[1];
                eredmeny[0] = van.ToString();
            }
            return eredmeny;
        }

        // Sorozatszámítás naplózással
        public static T SorozatSzamitas<T>(T[] x, int n) where T : INumber<T>
        {
            Console.WriteLine("\n--- SOROZATSZÁMÍTÁS (Összegzés) INDUL ---");
            T érték = x[0];
            Console.WriteLine($"Kezdőérték: {érték}");

            for (int i = 1; i < n; i++)
            {
                T regiErtek = érték;
                érték = érték + x[i];
                Console.WriteLine($"Művelet: {regiErtek} + {x[i]} = {érték}");
            }

            Console.WriteLine($"Végeredmény: {érték}");
            return érték;
        }

        // Megszámlálás naplózással
        public int Megszamlalas<T>(T[] x, int n, Predicate<T> P)
        {
            Console.WriteLine("\n--- MEGSZÁMLÁLÁS INDUL ---");
            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (P(x[i]))
                {
                    db = db + 1;
                    Console.WriteLine($"Találat: x[{i}] = {x[i]} | Eddigi darabszám: {db}");
                }
                else
                {
                    Console.WriteLine($"Kihagyva: x[{i}] = {x[i]}");
                }
            }
            Console.WriteLine($"Összesen {db} darab elem felelt meg.");
            return db;
        }

        // Maximumkiválasztás naplózással
        public static int MaximumKivalasztas<T>(T[] x, int n) where T : INumber<T>
        {
            Console.WriteLine("\n--- MAXIMUMKIVÁLASZTÁS INDUL ---");
            int max = 0;
            Console.WriteLine($"Kezdeti maximum: x[0] = {x[0]}");

            for (int i = 1; i < n; i++)
            {
                if (x[i] > x[max])
                {
                    Console.WriteLine($"Új maximum! x[{i}] ({x[i]}) > x[{max}] ({x[max]})");
                    max = i;
                }
                else
                {
                    Console.WriteLine($"x[{i}] ({x[i]}) nem nagyobb, marad a régi maximum.");
                }
            }
            Console.WriteLine($"A legvagyobb elem indexe: {max}, értéke: {x[max]}");
            return max;
        }
    }
}