using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_04;

internal class MainClass
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Halo Dunia");
        //Console.WriteLine("Zahrandi tamvan");
        //Console.WriteLine("Anyeongggggg");


        String jsonString = File.ReadAllText("E://SEMESTER 4/Konstruksi Perangkat Lunak/Praktikum/Modul 5/tpmodul6_kelompok_04/tp6_2_nim.json");

        KuliahMahasiswa1302204051 mhs1 = JsonSerializer.Deserialize<KuliahMahasiswa1302204051>(jsonString);

        //Console.WriteLine("Kode Mata Kuliah : " + mhs1.kode_matkul);
        //Console.WriteLine("Nama mata Kuliah : " + mhs1.nama_matkul);
    }
}
