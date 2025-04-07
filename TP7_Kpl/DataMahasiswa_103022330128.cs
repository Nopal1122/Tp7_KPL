using System;
using System.IO;
using System.Text.Json;

public class Nama  
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa_103822339128  
{
    public Nama nama { get; set; }  
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string jsonPath = "tp7_1_103822339128.json";
        string jsonString = File.ReadAllText(jsonPath);  
        DataMahasiswa_103822339128 data = JsonSerializer.Deserialize<DataMahasiswa_103822339128>(jsonString);  

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");  
    }
}
