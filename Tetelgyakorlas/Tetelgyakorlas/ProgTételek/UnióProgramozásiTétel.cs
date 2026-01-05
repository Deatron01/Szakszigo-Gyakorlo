using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class UnióProgramozásiTétel
    {
        // Bemenet: x1 - T tömb , n1 - egész (tömb mérete), x2 - T tömb , n2 - egész (tömb mérete)
        // Kimenet: y - T tömb, db - egész
        public static (T[] y, int db) Metszet<T>(T[] x1, int n1, T[] x2, int n2) where T : IEquatable<T>
        {
            Console.WriteLine("\n--- UNIO INDUL ---");
            T[] y = new T[n1+n2];
            for (int i = 0; i < n1; i++)
            {
                y[i] = x1[i];
            }
            Console.WriteLine($"Első tömb elemei belehelyezve az új tömbe");
            int db = n1;
            for (int j = 0; j < n2; j++)
            {
                int i = 0;
                while ((i < n1) & !x1[i].Equals(x2[j]))
                {
                    i = i + 1;
                }
                if (i > n1)
                {
                    db = db + 1;
                    y[db] = x2[j];
                }
            }
            Console.WriteLine($"Második tömb elemei belehelyezve az új tömbe");
            Console.WriteLine($"Unió kész. Unióban lévő elemek száma: {db} db");
            return (y, db);
        }
    }
}
