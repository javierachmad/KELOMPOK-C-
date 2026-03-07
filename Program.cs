
using System;
using Tugas2;


Mobil_sedan mobil1 = new Mobil_sedan();
Console.WriteLine("=== Info Awal ===");
mobil1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Nyalakan Mesin ===");
mobil1.NyalakanMesin();
mobil1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Matikan Mesin ===");
mobil1.MatikanMesin();
mobil1.TampilkanInfo();

Console.WriteLine();

Ikan ikan1 = new Ikan("Nemo", "Oranye", 5);
Console.WriteLine("=== Info Awal ===");
ikan1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Mulai Berenang ===");
ikan1.Berenang();
ikan1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Berhenti Berenang ===");
ikan1.Berhenti();
ikan1.TampilkanInfo();

Console.WriteLine();

Burung burung1 = new Burung("Elang", 120.5, true);
Console.WriteLine("=== Info Burung 1 ===");
burung1.Terbang();
burung1.Berkicau();

Console.WriteLine();

Burung burung2 = new Burung("Pinguin", 30.0, false);
Console.WriteLine("=== Info Burung 2 ===");
burung2.Terbang();
burung2.Berkicau();

Console.WriteLine() ;

Komputer pc1 = new Komputer("Asus", 16);
Console.WriteLine("=== Info Awal ===");
pc1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Nyalakan Komputer ===");
pc1.Nyalakan();
pc1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Nyalakan Lagi ===");
pc1.Nyalakan();

Console.WriteLine();

Console.WriteLine("=== Matikan Komputer ===");
pc1.Matikan();
pc1.TampilkanInfo();

Console.WriteLine();

Console.WriteLine("=== Matikan Lagi ===");
pc1.Matikan();
