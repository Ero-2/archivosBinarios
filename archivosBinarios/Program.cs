using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace archivosBinarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using (BinaryWriter writer = new BinaryWriter(File.Open("datos.bin", FileMode.Create)))
            {
                
                writer.Write(42);
                writer.Write("Hola, mundo!");
                writer.Write(3.14);
            }

           
            using (BinaryReader reader = new BinaryReader(File.Open("datos.bin", FileMode.Open)))
            {
              
                int entero = reader.ReadInt32();
                string cadena = reader.ReadString();
                double doble = reader.ReadDouble();

                
                Console.WriteLine("Entero: " + entero);
                Console.WriteLine("Cadena: " + cadena);
                Console.WriteLine("Doble: " + doble);

                Console.ReadKey();
            }

        }
    }
}
