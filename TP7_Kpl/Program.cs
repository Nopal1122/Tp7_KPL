using System;

namespace TP7_Kpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DATA MAHASISWA ===");
            DataMahasiswa_1038223300019.ReadJSON();

            Console.WriteLine("\n"); 

            Console.WriteLine("=== DAFTAR MATA KULIAH ===");
            KuliahMahasiswa_1030223300019.ReadJSON();

            Console.ReadLine(); 
        }
    }
}