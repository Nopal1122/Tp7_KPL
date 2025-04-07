using System;

namespace TP7_Kpl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deserialisasi Data Mahasiswa
            Console.WriteLine("=== DATA MAHASISWA ===");
            DataMahasiswa_103022330128.ReadJSON();

            Console.WriteLine("\n"); // Spasi

            // Deserialisasi Mata Kuliah
            Console.WriteLine("=== DAFTAR MATA KULIAH ===");
            KuliahMahasiswa_103022330128.ReadJSON();

            Console.ReadLine(); // Biarkan console terbuka
        }
    }
}