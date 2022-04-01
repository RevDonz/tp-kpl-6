using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_04
{
	internal class DataMahasiswa1302204051
	{

		public void ReadJSON()
		{
			// Membaca File JSON
			String jsonString = File.ReadAllText("E://SEMESTER 4/Konstruksi Perangkat Lunak/Tugas Pendahuluan/Modul 6/tpmodul6_kelompok_04/tp6_1_nim.json");

			// Convert JSON menjadi Array
			dynamic data = JsonConvert.DeserializeObject(jsonString);

			//
			Console.WriteLine("Nama " + data.nama_depan + " " + data.nama_belakang + " dengan NIM " + data.nim + " dari Fakultas " + data.fakultas);
		}
	}
}