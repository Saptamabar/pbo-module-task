using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Buat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Buat beberapa objek dari berbagai jenis hewan
        Singa singa = new Singa { nama = "Simba", umur = 5, jumlahKaki = 4 };
        Gajah gajah = new Gajah { nama = "Dumbo", umur = 10, jumlahKaki = 4 };
        Ular ular = new Ular { nama = "Kaa", umur = 3, PanjangTubuh = 2.5 };
        Buaya buaya = new Buaya { nama = "Gator", umur = 7, PanjangTubuh = 4.0 };

        // Tambahkan hewan-hewan tersebut ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Panggil method DaftarHewan() untuk menampilkan semua hewan
        kebunBinatang.DaftarHewan();

        // Demonstrasi penggunaan polymorphism
        Console.WriteLine("\nDemonstrasi Polymorphism:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        // Panggil method khusus
        Console.WriteLine("\nMethod Khusus:");
        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());
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
        return "Gajah berbunyi: Prroooo!";
    }
}

class Singa : Mamalia
{
    public override string Suara()
    {
        return "Singa berbunyi: Roaaar!";
    }

    public string Mengaum()
    {
        return "Singa mengaum keras!";
    }
}

class Ular : Reptil
{
    public override string Suara()
    {
        return "Ular berbunyi: Ssssss!";
    }

    public string Merayap()
    {
        return "Ular merayap di tanah";
    }
}

class Buaya : Reptil
{
    public override string Suara()
    {
        return "Buaya berbunyi: Groook!";
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
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}
