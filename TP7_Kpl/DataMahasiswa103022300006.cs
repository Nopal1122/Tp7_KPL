using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300006
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        string path = "tp7_1_103022300006.json";
        string jsonString = File.ReadAllText(path);
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}