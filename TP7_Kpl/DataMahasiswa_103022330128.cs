using System;
using System.IO;
using System.Text.Json;

public class Nama
{
	public string depan { get; set; }
	public string belakang { get; set; }
}

public class DataMahasiswa_103022330128
{
	public Nama nama { get; set; }
	public string nim { get; set; }
	public string fakultas { get; set; }

	public static void ReadJSON()
	{
		string filePath = "tp7_1_103022330128.json";
		string jsonString = File.ReadAllText(filePath);
		DataMahasiswa data = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);

		Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
	}
}