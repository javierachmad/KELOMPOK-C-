using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas2
{
    class Ikan
    {
        // Properti
        public string Nama;
        public string Warna;
        public int PanjangSirip;
        public bool SedangBerenang;

        // Konstruktor
        public Ikan(string nama, string warna, int panjangSirip)
        {
            Nama = nama;
            Warna = warna;
            PanjangSirip = panjangSirip;
            SedangBerenang = false;
        }

        // Method berenang menggunakan sirip
        public void Berenang()
        {
            SedangBerenang = true;
            Console.WriteLine($"{Nama} sedang berenang menggunakan sirip sepanjang {PanjangSirip} cm!");
        }

        // Method berhenti berenang
        public void Berhenti()
        {
            if (SedangBerenang)
            {
                SedangBerenang = false;
                Console.WriteLine($"{Nama} berhenti berenang.");
            }
            else
            {
                Console.WriteLine($"{Nama} memang sedang tidak berenang.");
            }
        }

        // Method menampilkan info ikan
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}, Warna: {Warna}, Panjang Sirip: {PanjangSirip} cm");
            Console.WriteLine($"Sedang Berenang: {SedangBerenang}");
        }
    }
}