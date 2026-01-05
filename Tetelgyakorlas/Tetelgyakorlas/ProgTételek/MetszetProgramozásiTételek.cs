using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class MetszetProgramozásiTételek
    {
        // Bemenet: x1 - T tömb , n1 - egész (tömb mérete), x2 - T tömb , n2 - egész (tömb mérete)
        // Kimenet: y - T tömb, db - egész
        public static (T[] y, int db) Metszet<T>(T[] x1, int n1, T[] x2, int n2)where T : IEquatable<T>
        {
            Console.WriteLine("\n--- METSZET INDUL ---");
            T[] y = new T[n1];
            int db = 0;
            for (int i = 0; i < n1; i++)
            {
                int j = 1;
                while((j < n2) & !x1[i].Equals(x2[j]))
                {
                    j ++;
                } 
                if (j < n2)
                {
                    Console.WriteLine($"Megfelelő elem: x1[{i}] ({x1[i]}) és x2[{j}] ({x2[j]}). Áthelyezés az y[{db}] pozícióba.");
                    db = db + 1;
                    y[db] = x1[i];
                }
            }
            Console.WriteLine($"Metszet kész. Metszet száma: {db} db");
            return (y, db);
        }


        // Bemenet: x1 - T tömb , n1 - egész (tömb mérete), x2 - T tömb , n2 - egész (tömb mérete)
        // Kimenet: van - Logikai
        public static bool MetszetEldöntése<T>(T[] x1, int n1, T[] x2, int n2) where T : IEquatable<T>
        {
            Console.WriteLine("\n--- METSZETELDÖNTÉS INDUL ---");
            int i = 0;
            bool van = false;
            while ((i < n1)&!van)
            {
                int j = 1;
                while ((j < n2) & !x1[i].Equals(x2[j]))
                {
                    j++;
                }
                if (j <= n2)
                {
                    van = true;
                    Console.WriteLine($"Megfelelő elem: x1[{i}] ({x1[i]}) és x2[{j}] ({x2[j]}). Vissza {van}.");
                }
                else
                {
                    i = i + 1;
                }
            }
            Console.WriteLine($"Metszeteldöntés eldöntve. Válasz: {van}");
            return van;
        }
    }
}
