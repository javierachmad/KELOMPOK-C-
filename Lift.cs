using System;


public class Lift
{
    private bool Bergerak;
    private string Tombol;
    private string No_Lantai;

    public Lift(bool Bergerak, string Tombol, string No_Lantai)
    {
        this.Bergerak = Bergerak;
        this.Tombol = Tombol;
        this.No_Lantai = No_Lantai;
    }

    public void TampilInfo()
    {
        Console.WriteLine("Bergerak  : " + Bergerak);
        Console.WriteLine("Tombol    : " + Tombol);
        Console.WriteLine("No Lantai : " + No_Lantai);
        Console.WriteLine("----------");
    }

    public virtual void CekStatus()
    {
        Console.WriteLine("[Lift] Mengecek status...");
    }
}


public class LiftPenumpang : Lift
{
    private string JumlahOrang;
    private bool LiftPenuh;

    public LiftPenumpang(bool Bergerak, string Tombol, string No_Lantai,
                         string JumlahOrang, bool LiftPenuh)
        : base(Bergerak, Tombol, No_Lantai)
    {
        this.JumlahOrang = JumlahOrang;
        this.LiftPenuh = LiftPenuh;
    }

    public void TampilPenumpang()
    {
        TampilInfo();
        Console.WriteLine("Jumlah Orang : " + JumlahOrang);
        Console.WriteLine("Lift Penuh   : " + LiftPenuh);
    }

    public override void CekStatus()
    {
        if (LiftPenuh)
            Console.WriteLine("Lift PENUH, harap tunggu!");
        else
            Console.WriteLine("Lift TERSEDIA, silakan masuk.");
    }
}

class Program
{
    static void Main()
    {
        LiftPenumpang lift = new LiftPenumpang(
            true,      
            "Lantai 3", 
            "3",       
            "6 Orang", 
            false      
        );

        lift.TampilPenumpang();
        lift.CekStatus();
    }
}
