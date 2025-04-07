using System;

namespace TP7_Kpl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("=== DATA MAHASISWA ===");
            DataMahasiswa_103022330128.ReadJSON();

            Console.WriteLine("\n"); 

            
            Console.WriteLine("=== DAFTAR MATA KULIAH ===");
            KuliahMahasiswa_103022330128.ReadJSON();

            Console.ReadLine(); 
        }
    }
}
