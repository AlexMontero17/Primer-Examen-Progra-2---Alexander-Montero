using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Progra_2___Alexander_Montero
{

    public static class Vehiculos
    {
        private static string[] codigo;
        private static string[] marca;
        private static float[] costo;
        private static string[] modelo;

        public static string[] Codigo { get => codigo; set => codigo = value; }
        public static string[] Marca { get => marca; set => marca = value; }
        public static float[] Costo { get => costo; set => costo = value; }
        public static string[] Modelo { get => modelo; set => modelo = value; }

        public static void AgregarVehiculos()
        {
            Codigo = new string[5];
            Marca = new string[5];
            Costo = new float[5];
            Modelo = new string[5];

            string linea;
            int i;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");

            for (i = 0; i<Codigo.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, ingresar la información del vehículo");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nCódigo del vehículo:");
                Codigo[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la marca: ");
                Marca[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el costo: ");
                linea = Console.ReadLine();
                Costo[i] = float.Parse(linea);

                Console.WriteLine("Ingrese el modelo: ");
                Modelo[i] = Console.ReadLine();
                Console.WriteLine("\n");
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al sub menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ModificarVehiculo(int codigo, string marca, float costo, string modelo)
        {
            string linea;
            string codigos;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Indique el código del vehiculo a modificar");
            Console.ForegroundColor = ConsoleColor.Blue;
            codigos = Console.ReadLine();
            

            for (int i = 0; i < 5; i++)
            {
                if (codigos == Codigo[i])
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPor favor, ingresar la información del vehículo");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ingrese la marca: ");
                    Marca[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese el costo: ");
                    linea = Console.ReadLine();
                    Costo[i] = float.Parse(linea);

                    Console.WriteLine("Ingrese el modelo: ");
                    Modelo[i] = Console.ReadLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al sub menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Consulta()
        {
            string codigos;
            Boolean existencia = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite el código del vehículo a consultar: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            codigos = Console.ReadLine();
            

            for (int i = 0; i < 5; i++)
            {
                if (codigos == Codigo[i])
                {
                    Console.WriteLine("\nLa marca es: " + Marca[i]);
                    Console.WriteLine("El costo es: " + Costo[i]);
                    Console.WriteLine("El modelo es: " + Modelo[i]);
                    existencia = true;

                }
            }
            if (existencia == false)
            {
                Console.WriteLine("El vehículo no existe...");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al sub menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Reportes()
        {   
            int j;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            for (int i = 0; i < 5; i++)
            {
                j = i + 1;
            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Información del vehículo # " + j + " ingresado." );
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("La marca es: " + Codigo[i]);
                Console.WriteLine("La marca es: " + Marca[i]);
                Console.WriteLine("El costo es: " + Costo[i]);
                Console.WriteLine("El modelo es: " + Modelo[i]);   
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al sub menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
