using System;
using System.Collections.Generic;
using System.Text;

namespace nyoba
{
    internal class mobil_sedan
    {
        // Private fields
        private string merk;
        private string warna;
        private int tahun;
        private bool mesinHidup;

        public mobil_sedan()
        {
            merk = "Sedan";
            warna = "Biru";
            tahun = 2000;
            mesinHidup = false;
        }

        // Method boolean - nyalakan/matikan mesin
        public void NyalakanMesin()
        {
            mesinHidup = true;
            Console.WriteLine("Mesin dinyalakan!");
        }

        public void MatikanMesin()
        {
            mesinHidup = false;
            Console.WriteLine("Mesin dimatikan!");
        }

        // Method GET
        public void TampilkanInfo()
        {
            Console.WriteLine("Merk        : " + merk);
            Console.WriteLine("Warna       : " + warna);
            Console.WriteLine("Tahun       : " + tahun);
            Console.WriteLine("Status Mesin: " + (mesinHidup ? "Menyala" : "Mati"));
        }
    }
}