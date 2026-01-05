using Tetelgyakorlas;
using Tetelgyakorlas.ProgTételek;

// 1. A kért adatszerkezet létrehozása és feltöltése
var SegedTömb = new Tömb<int[]>
{
    Tartalom = new int[] { 12, -5, 8, 22, 0, 15, 31 }
};

// Rövidítések a könnyebb kezelhetőségért
int[] adatok = SegedTömb.Tartalom;
int n = adatok.Length;

// Osztályok példányosítása a nem-statikus metódusokhoz
var egyszerű = new EgyszeruProgramozasiTetelek();
var kivalogatasOsztaly = new KiválogatásProgramozásiTételek();

Console.WriteLine("========== PROGRAMOZÁSI TÉTELEK TESZTELÉSE ==========");
Console.WriteLine($"Bemeneti tömb: [{string.Join(", ", adatok)}]");
Console.WriteLine($"Elemek száma (n): {n}");

// --- SOROZATSZÁMÍTÁS ---
int osszeg = EgyszeruProgramozasiTetelek.SorozatSzamitas(adatok, n);
Console.WriteLine($"\n>> EREDMÉNY (Összegzés): {osszeg}");

// --- ELDÖNTÉS ---
// Van-e benne negatív szám?
bool vanNegativ = EgyszeruProgramozasiTetelek.Eldontes(adatok, n, x => x < 0);
Console.WriteLine($"\n>> EREDMÉNY (Van negatív?): {vanNegativ}");

// --- LINEÁRIS KERESÉS ---
// Keressük a 22-es számot
string[] keresesEredmeny = egyszerű.LinearisKereses(adatok, n, x => x == 22);
if (keresesEredmeny[0] == "True")
    Console.WriteLine($"\n>> EREDMÉNY (Keresés): Megtalálva a(z) {keresesEredmeny[1]}. indexen.");
else
    Console.WriteLine("\n>> EREDMÉNY (Keresés): Nincs ilyen elem.");

// --- MEGSZÁMLÁLÁS ---
// Hány páros szám van?
int parosDb = egyszerű.Megszamlalas(adatok, n, x => x % 2 == 0);
Console.WriteLine($"\n>> EREDMÉNY (Párosak száma): {parosDb}");

// --- MAXIMUMKIVÁLASZTÁS ---
int maxIdx = EgyszeruProgramozasiTetelek.MaximumKivalasztas(adatok, n);
Console.WriteLine($"\n>> EREDMÉNY (Maximum): Érték: {adatok[maxIdx]}, Index: {maxIdx}");

// --- SZÉTVÁLOGATÁS (Tuple visszatéréssel) ---
// Válogassuk szét a 10-nél nagyobbakat a többitől
var szetv = SzétválogatásProgramozásiTételek.Szetvalogatas(adatok, n, x => x > 10);

Console.WriteLine("\n>> EREDMÉNY (Szétválogatás):");
Console.Write("   10-nél nagyobbak: ");
for (int i = 0; i < szetv.db1; i++) Console.Write(szetv.y1[i] + " ");

Console.Write("\n   Egyéb számok: ");
for (int i = 0; i < szetv.db2; i++) Console.Write(szetv.y2[i] + " ");


// ---SZÉTVÁLOGATÁS 1 tömben(Tuple visszatéréssel)-- -
// Válogassuk szét a 10-nél nagyobbakat a többitől
var szetv2 = SzétválogatásProgramozásiTételek.SzetvalogatasEgyUjTombe(adatok, n, x => x > 10);

Console.WriteLine("\n>> EREDMÉNY (Szétválogatás):");
Console.Write("   10-nél nagyobbak: ");
for (int i = 0; i < szetv2.db; i++) Console.Write(szetv2.y[i] + " ");

Console.WriteLine("\n\n================ TESZT VÉGE ================");
Console.ReadLine();