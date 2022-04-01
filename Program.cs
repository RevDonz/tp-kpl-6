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
        DataMahasiswa1302204080 mhs1 = new DataMahasiswa1302204080();
        mhs1.ReadJSON();

        KuliahMahasiswa1302204080 dataMhs1 = new KuliahMahasiswa1302204080();
        dataMhs1.ReadJSON();
    }
}
