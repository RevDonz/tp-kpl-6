using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_04
{
    internal class KuliahMahasiswa1302200022
    {
        public void ReadJSON()
        {
            // Membaca File JSON
            String jsonString = File.ReadAllText("C:/Users/HP/Documents/KPL/tp-kpl-6-master/tp6_2_nim.json");

            // Convert JSON menjadi Array
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            // Menampilkan JSON dengan Loop Foreach
            foreach (var item in array)
            {
                Console.WriteLine();
                Console.WriteLine("Kode matkul : " + item.kode_matkul);
                Console.WriteLine("Nama matkul : " + item.nama_matkul);
            }

        }

}

}
