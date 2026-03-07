using System;

namespace Tugas2
{
    internal class Burung
    {
        // Properti (tanpa get; set;)
        public string Nama;
        public double PanjangSayap;
        public bool BisaTerbang;

        // Konstruktor
        public Burung(string nama, double panjangSayap, bool bisaTerbang)
        {
            Nama = nama;
            PanjangSayap = panjangSayap;
            BisaTerbang = bisaTerbang;
        }

        // Method
        public void Terbang()
        {
            Console.WriteLine(BisaTerbang
                ? $"{Nama} terbang dengan sayap {PanjangSayap} cm."
                : $"{Nama} tidak bisa terbang.");
        }

        public void Berkicau()
        {
            Console.WriteLine($"{Nama} berkicau: Cuit cuit!");
        }
    }

}
