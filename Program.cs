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
        DataMahasiswa1302200022 mhs1 = new DataMahasiswa1302200022();
        mhs1.ReadJSON();

        KuliahMahasiswa1302200022 dataMhs1 = new KuliahMahasiswa1302200022();
        dataMhs1.ReadJSON();
    }
}
