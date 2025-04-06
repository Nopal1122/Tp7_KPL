using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa103022300006
{
    public class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    public class Kuliah
    {
        public List<MataKuliah> mata_kuliah { get; set; }
    }

    public static void ReadJSON()
    {
        string path = "tp7_2_103022300006.json";
        string jsonString = File.ReadAllText(path);
        Kuliah kuliah = JsonSerializer.Deserialize<Kuliah>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int index = 1;
        foreach (var mk in kuliah.mata_kuliah)
        {
            Console.WriteLine($"MK {index++} {mk.kode} - {mk.nama}");
        }
    }
}