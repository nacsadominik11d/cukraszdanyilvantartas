//2.fa
using cukraszdanyilvantartas;

List<Sutemeny> sutik = new List<Sutemeny>();
//3.fa
for (int i = 0; i < 4; i++)
{
    Sutemeny aktualis = new Sutemeny();
    Console.WriteLine($"{i + 1}. sütemény adatai:");

    Console.Write($"\tNév: ");
    aktualis.Nev = Console.ReadLine();

    Console.Write($"\tEgységár (Ft): ");
    aktualis.Egysegar = int.Parse(Console.ReadLine());

    Console.Write("\tRaktáron (db): ");
    aktualis.Raktarondb = int.Parse(Console.ReadLine());
    Console.WriteLine();
    sutik.Add(aktualis);
    
}
//4.1fa
int osszeg = 0;
int listdb = sutik.Count;
Console.WriteLine("Pultban lévő sütemények:");
int teljes = 0;
double arak = 0;
for (int i = 0; i < listdb; i++) 
{
    osszeg = sutik[i].Egysegar * sutik[i].Raktarondb;
    Console.WriteLine($"{sutik[i].Nev}: {sutik[i].Egysegar}Ft / db ({sutik[i].Raktarondb}db) --> Összérték: {osszeg} Ft ");
    teljes += osszeg;
    arak += sutik[i].Egysegar;
}
//4.2fa
Console.WriteLine($"\nPult teljes készletértéke: {teljes} Ft");
double atlag = arak/listdb;
Console.WriteLine($"Sütemények átlagos egységára: {atlag:F0} Ft");

//4.3
if (teljes >= 40000) Console.WriteLine("Bőséges kínálat!");
else if (teljes >= 20000) Console.WriteLine("Átlagos feltöltöttség.");
else  Console.WriteLine("Alacsony készlet, utántöltés szükséges!");