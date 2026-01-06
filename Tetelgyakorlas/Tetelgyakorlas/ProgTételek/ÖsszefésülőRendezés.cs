using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetelgyakorlas.ProgTételek
{
    internal class ÖsszefésülőRendezés
    {
        // Bemenet: x - T tömb , bal - egész , jobb - egész
        // Kimenet: x - T rendezett tömb
        public static void OsszefesuloRendezes<T>(ref T[] x, int bal, int jobb) where T : IComparable<T>
        {
            Console.WriteLine("\n--- OsszefesuloRendezes ---");
            if (bal < jobb)
            {
                int center = (bal + jobb) / 2;
                OsszefesuloRendezes(ref x, bal, center);
                OsszefesuloRendezes(ref x, center+1, jobb);
                Osszefesul(ref x, bal, center, jobb);

            }
        }


        // Bemenet: x - T tömb , bal - egész , center - egész, jobb - egész
        // Kimenet: x - T tömb
        public static void Osszefesul<T>(ref T[] x, int bal,int center, int jobb) where T : IComparable<T>
        {
            Console.WriteLine("\n--- Osszefesul ---");
            int n1 = center - bal + 1;
            int n2 = jobb - center;
            T[] y1 = new T[n1+1];
            for (int i = 0; i < n1; i++) 
            { 
                y1[i] = x[bal+i-1];
            }
            T[] y2 = new T[n2+1];
            for (int j = 0; j < n2; j++)
            {
                y2[j] = x[center + j];
            }
            y1[n1 + 1] =  (T)typeof(T).GetField("MaxValue").GetValue(null);
            y2[n2 + 1] = (T)typeof(T).GetField("MaxValue").GetValue(null);
            int
        }
    }
}
