using System;

namespace SistemLift
{
    
    public class Lift
    {
        public string Nama;
        private bool _bergerak;
        private string _tombol;
        private string _noLantai;

        public bool Bergerak
        {
            get { return _bergerak; }
            set { _bergerak = value; }
        }

        public string Tombol
        {
            get { return _tombol; }
            set
            {
                if (value != "")
                    _tombol = value;
                else
                    Console.WriteLine("[ERROR] Tombol tidak boleh kosong.");
            }
        }

        public string NoLantai
        {
            get { return _noLantai; }
            set
            {
                if (int.TryParse(value, out int lantai) && lantai >= 1 && lantai <= 100)
                    _noLantai = value;
                else
                    Console.WriteLine($"[ERROR] Nomor lantai tidak valid: {value}");
            }
        }

        public Lift(string nama, bool bergerak, string tombol, string noLantai)
        {
            Nama = nama;
            Bergerak = bergerak;
            Tombol = tombol;
            NoLantai = noLantai;
        }

        public void TampilInfo()
        {
            Console.WriteLine("Nama      : " + Nama);
            Console.WriteLine("Bergerak  : " + Bergerak);
            Console.WriteLine("Tombol    : " + Tombol);
            Console.WriteLine("No Lantai : " + NoLantai);
            Console.WriteLine("----------");
        }

        public virtual void CekStatus()
        {
            if (_bergerak)
                Console.WriteLine($"[Lift] {Nama} sedang bergerak menuju lantai {NoLantai}.");
            else
                Console.WriteLine($"[Lift] {Nama} sedang berhenti di lantai {NoLantai}.");
        }
    }

    
    public class LiftPenumpang : Lift
    {
        private int _jumlahOrang;
        private bool _liftPenuh;

        public int JumlahOrang
        {
            get { return _jumlahOrang; }
            set
            {
                if (value < 0)
                    Console.WriteLine("[ERROR] Jumlah orang tidak boleh negatif.");
                else if (value > 20)
                    Console.WriteLine("[ERROR] Jumlah orang melebihi kapasitas maksimum (20).");
                else
                    _jumlahOrang = value;
            }
        }

        public bool LiftPenuh
        {
            get { return _liftPenuh; }
            set { _liftPenuh = value; }
        }

        public LiftPenumpang(string nama, bool bergerak, string tombol, string noLantai,
                             int jumlahOrang, bool liftPenuh)
            : base(nama, bergerak, tombol, noLantai)
        {
            JumlahOrang = jumlahOrang;
            LiftPenuh = liftPenuh;
        }

        public void TampilPenumpang()
        {
            TampilInfo();
            Console.WriteLine("Jumlah Orang : " + JumlahOrang);
            Console.WriteLine("Lift Penuh   : " + LiftPenuh);
            Console.WriteLine("----------");
        }

        public override void CekStatus()
        {
            if (LiftPenuh)
                Console.WriteLine($"LiftPenumpang {Nama} PENUH ({JumlahOrang} orang), harap tunggu!");
            else if (Bergerak)
                Console.WriteLine($"LiftPenumpang {Nama} sedang bergerak. ({JumlahOrang} orang di dalam)");
            else
                Console.WriteLine($"LiftPenumpang {Nama} TERSEDIA, silakan masuk. ({JumlahOrang} orang di dalam)");
        }
    }


    public class LiftBarang : Lift
    {
        private double _beratMuatan;
        private double _batasBeban;

        public double BeratMuatan
        {
            get { return _beratMuatan; }
            set
            {
                if (value < 0)
                    Console.WriteLine("[ERROR] Berat muatan tidak boleh negatif.");
                else if (value > _batasBeban)
                    Console.WriteLine($"[ERROR] Berat muatan melebihi batas ({_batasBeban} kg).");
                else
                    _beratMuatan = value;
            }
        }

        public double BatasBeban
        {
            get { return _batasBeban; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("[ERROR] Batas beban harus lebih dari 0.");
                else
                    _batasBeban = value;
            }
        }

        public LiftBarang(string nama, bool bergerak, string tombol, string noLantai,
                          double beratMuatan, double batasBeban)
            : base(nama, bergerak, tombol, noLantai)
        {
            BatasBeban = batasBeban;
            BeratMuatan = beratMuatan;
        }

        public void TampilBarang()
        {
            TampilInfo();
            Console.WriteLine("Berat Muatan : " + BeratMuatan + " kg");
            Console.WriteLine("Batas Beban  : " + BatasBeban + " kg");
            Console.WriteLine("----------");
        }

        public override void CekStatus()
        {
            if (BeratMuatan >= BatasBeban)
                Console.WriteLine($"LiftBarang {Nama} KELEBIHAN BEBAN ({BeratMuatan} kg), tidak dapat bergerak!");
            else if (Bergerak)
                Console.WriteLine($"LiftBarang {Nama} sedang bergerak membawa {BeratMuatan} kg.");
            else
                Console.WriteLine($"LiftBarang {Nama} siap dimuati. Sisa kapasitas: {BatasBeban - BeratMuatan} kg.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Uji LiftPenumpang
            LiftPenumpang liftP = new LiftPenumpang(
                "LP-01", true, "Lantai 5", "5", 6, false
            );
            liftP.TampilPenumpang();
            liftP.CekStatus();

            Console.WriteLine();

            // Uji LiftBarang
            LiftBarang liftB = new LiftBarang(
                "LB-01", false, "Lantai 2", "2", 300, 1000
            );
            liftB.TampilBarang();
            liftB.CekStatus();

            Console.WriteLine();

            // Uji validasi
            Console.WriteLine("=== Uji Validasi ===");
            liftP.JumlahOrang = -1;
            liftP.JumlahOrang = 25;
            liftB.BeratMuatan = -50;
            liftB.BeratMuatan = 1500;
            liftP.NoLantai = "0";
            liftP.NoLantai = "abc";
            liftP.Tombol = "";

            Console.WriteLine();

            // Uji polymorphism — CekStatus dipanggil lewat referensi induk
            Console.WriteLine("=== Uji Polymorphism ===");
            Lift[] daftarLift = {
                new Lift("Lift-Umum", false, "Lantai 1", "1"),
                new LiftPenumpang("LP-02", false, "Lantai 3", "3", 10, true),
                new LiftBarang("LB-02", true, "Lantai 7", "7", 800, 1000)
            };

            foreach (Lift l in daftarLift)
            {
                l.CekStatus();
            }
        }
    }
}
