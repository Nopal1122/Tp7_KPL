using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static DataMahasiswa103022300145;
using static System.Runtime.InteropServices.JavaScript.JSType;

class KuliahMahasiswa103022300145
{
    public class Matakuliah
    {
        public string kode
        {
            get; set;
        }

        public string nama
        {
            get; set;
        }
    }
    public Matakuliah[] mata_kuliah { get; set; }
    public static void ReadJSON()
    {
        string path = "tp7_2_103022300145.json";
        string jsonString = File.ReadAllText(path);
        KuliahMahasiswa103022300145 klh = JsonSerializer.Deserialize<KuliahMahasiswa103022300145>(jsonString);
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < klh.mata_kuliah.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {klh.mata_kuliah[i].kode} - {klh.mata_kuliah[i].nama}");
        }
    }
}