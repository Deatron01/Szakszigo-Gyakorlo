using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class RészhalmazVizsgálatHalmazokUniojaMetszeteKülömbsége
    {
        // Bemenet: a - T halmaz , m - egész, b - T Halmaz, n - egész
        // Kimenet: l - logikai

        public static bool ReszhalmazE<T>(T[] a, int m, T[] b, int n) where T : IComparable<T>
        {
            Console.WriteLine("\n--- RÉSZHALMAZ E ALGORITMUS ---");
            int i = 0;
            int j = 0;
            while ((i < m) & (j < n) & (0 <= a[i].CompareTo(b[j])))
            {
                if (a[i].Equals(b[j]))
                {
                    i = i + 1;
                }
                j = j + 1;
            }

            bool l = (i > m);
            return l;
        }

        // Bemenet: a1 - T halmaz , n1 - egész, a2 - T Halmaz, n2 - egész
        // Kimenet: b - T halmaz, db - egész

        public static (T[] b, int db) HalmazUnio<T>(T[] a1, int n1, T[] a2, int n2) where T : IComparable<T>
        {
            Console.WriteLine("\n--- HALMAZ UNIO ALGORITMUS ---");
            T[] b = new T[n1 + n2];
            int i = 0;
            int j = 0;
            int db = 0;

            n1 = n1 + 1;
            T[] tempA1 = new T[n1];
            Array.Copy(a1, tempA1, n1);

            n2 = n2 + 1;
            T[] tempA2 = new T[n2];
            Array.Copy(a2, tempA2, n2);


            T vegtelen = (T)typeof(T).GetField("MaxValue").GetValue(null);
            tempA1[n1] = vegtelen;
            tempA2[n2] = vegtelen;


            while (i < n1 || j < n2)
            {
                db = db + 1;

                if (tempA1[i].CompareTo(tempA2[j]) < 0)
                {
                    b[db] = tempA1[i];
                    i++;
                }
                else if (tempA1[i].CompareTo(tempA2[j]) > 0)
                {
                    b[db] = tempA2[j];
                    j++;
                }
                else
                {
                    b[db] = tempA1[i];
                    i++;
                    j++;
                }
            }

            return (b, db);
        }


        // Bemenet: a1 - T halmaz , n1 - egész, a2 - T Halmaz, n2 - egész
        // Kimenet: b - T halmaz, db - egész

        public static (T[] b, int db) HalmazMetszete<T>(T[] a1, int n1, T[] a2, int n2) where T : IComparable<T>
        {
            Console.WriteLine("\n--- HALMAZ METSZET ALGORITMUS ---");
            T[] b = new T[Math.Min(n1, n2)];
            int i = 0;
            int j = 0;
            int db = 0;
            while (i < n1 && j < n2)
            {
                if (0 > a1[i].CompareTo(a2[j]))
                {
                    i = i + 1;
                }
                else if (0 < a1[i].CompareTo(a2[j]))
                {
                    j = j + 1;
                }
                else
                {
                    db = db + 1;
                    b[db] = a1[i];
                    i = i + 1;
                    j = j + 1;
                }

            }
            return (b, db);
        }



        // Bemenet: a1 - T halmaz , n1 - egész, a2 - T Halmaz, n2 - egész
        // Kimenet: b - T halmaz, db - egész

        public static (T[] b, int db) HalmazKulombsege<T>(T[] a1, int n1, T[] a2, int n2) where T : IComparable<T>
        {
            Console.WriteLine("\n--- HALMAZ KULOMBSEGE ALGORITMUS ---");
            T[] b = new T[n1];
            int i = 0;
            int j = 0;
            int db = 0;
            while (i < n1 && j < n2)
            {
                if (0 > a1[i].CompareTo(a2[j]))
                {
                    db = db + 1;
                    b[db] = a1[i];
                    i = i + 1;
                }
                else if (0 < a1[i].CompareTo(a2[j]))
                {
                    j = j + 1;
                }
                else
                {
                    i = i + 1;
                    j = j + 1;
                }
            }
            while (i < n1)
            {
                db = db + 1;
                b[db]  = a1[i];
                i = i + 1;
            }
            return (b, db);
        }
    }
}
