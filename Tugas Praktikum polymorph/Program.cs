using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    { 
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa();
        Gajah gajah = new Gajah();
        Ular ular = new Ular();
        Buaya buaya = new Buaya();

        singa.nama = "Fathan";
        singa.umur = 8;
        singa.jumlahKaki = 4;

        gajah.nama = "Elsa";
        gajah.umur = 7;
        gajah.jumlahKaki = 4;

        ular.nama = "Aia";
        ular.umur = 5;
        ular.PanjangTubuh = 10;

        buaya.nama = "rayan";
        buaya.umur = 6;
        buaya.PanjangTubuh = 3;

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nPolymorphism pada method suara:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nMethod Khusus:");
        singa.Mengaum();
        ular.Merayap();
    }
}

class Hewan
{
    public string nama;
    public int umur;

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {nama}, Umur: {umur}";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

class Gajah : Mamalia
{
    public override string Suara()
    {
        return "Gajah bersuara";
    }
}

class Singa : Mamalia
{
    public override string Suara()
    {
        return "Singa bersuara";
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum!! rawr");
    }
}

class Ular : Reptil
{
    public override string Suara()
    {
        return "Ular bersuara";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular merayap di tanah");
    }
}

class Buaya : Reptil
{
    public override string Suara()
    {
        return "Buaya bersuara";
    }
}

class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (Hewan hewan in koleksiHewan)
        {
            Console.WriteLine($" {hewan} \n  - {hewan.InfoHewan()}");
        }
    }
}
