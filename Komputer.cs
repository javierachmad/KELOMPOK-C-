using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas2
{
    class Komputer
    {
        // Properti
        public string Merk;
        public int RAM;
        public bool SedangMenyala;

        // Konstruktor
        public Komputer(string merk, int ram)
        {
            Merk = merk;
            RAM = ram;
            SedangMenyala = false;
        }

        // Method menyalakan komputer
        public void Nyalakan()
        {
            if (SedangMenyala)
            {
                Console.WriteLine($"{Merk} sudah menyala!");
            }
            else
            {
                SedangMenyala = true;
                Console.WriteLine($"{Merk} dinyalakan, komputer mulai menyala!");
            }
        }

        // Method mematikan komputer
        public void Matikan()
        {
            if (SedangMenyala)
            {
                SedangMenyala = false;
                Console.WriteLine($"{Merk} dimatikan.");
            }
            else
            {
                Console.WriteLine($"{Merk} memang sedang tidak menyala.");
            }
        }

        // Method menampilkan info komputer
        public void TampilkanInfo()
        {
            Console.WriteLine($"Merk: {Merk}, RAM: {RAM} GB");
            Console.WriteLine($"Sedang Menyala: {SedangMenyala}");
        }
    }

}
