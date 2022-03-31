using Newtonsoft.Json;
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
        // Membaca File JSON
        String jsonString = File.ReadAllText("E://SEMESTER 4/Konstruksi Perangkat Lunak/Praktikum/Modul 5/tpmodul6_kelompok_04/tp6_2_nim.json");

        // Convert JSON menjadi Array
        dynamic array = JsonConvert.DeserializeObject(jsonString);

        // Menampilkan JSON dengan Loop Foreach
        foreach (var item in array)
        {
            Console.WriteLine("Kode matkul : " + item.kode_matkul);
            Console.WriteLine("Nama matkul : " + item.nama_matkul + "\n");
        }
    }
}
