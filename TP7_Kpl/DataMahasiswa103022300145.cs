using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class DataMahasiswa103022300145
{
    public class Nama
    {
        public string depan
        {
            get; set;
        }

        public string belakang
        {
            get; set;
        }
    }
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public String nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON()
    {
        string path = "tp7_1_103022300145.json";
        string jsonString = File.ReadAllText(path);
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}