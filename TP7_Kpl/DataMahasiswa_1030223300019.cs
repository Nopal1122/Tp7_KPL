using System;
using System.IO;
using System.Text.Json;

namespace TP7_Kpl
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class DataMahasiswa_1038223300019
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }

        public static void ReadJSON()
        {
            string jsonPath = "test1.json";
            string jsonString = File.ReadAllText(jsonPath);
            DataMahasiswa_1038223300019 data = JsonSerializer.Deserialize<DataMahasiswa_1038223300019>(jsonString);

            Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}