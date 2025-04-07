using System;
using System.IO;
using System.Text.Json;

namespace TP7_Kpl
{
	public class Course
	{
		public string code { get; set; }
		public string name { get; set; }
	}

	public class KuliahMahasiswa_1030223300019
	{
		public Course[] courses { get; set; }

		public static void ReadJSON()
		{
			string jsonPath = "test2.json";
			string jsonString = File.ReadAllText(jsonPath);
            KuliahMahasiswa_1030223300019 data = JsonSerializer.Deserialize<KuliahMahasiswa_1030223300019>(jsonString);

			Console.WriteLine("Daftar mata kuliah yang diambil :");
			for (int i = 0; i < data.courses.Length; i++)
			{
				Console.WriteLine($"MK {i + 1} {data.courses[i].code} - {data.courses[i].name}");
			}
		}
	}
}