using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Progra_2___Alexander_Montero
{
    internal class Tipo
    {
        List<String> tipos = new List<String>() { "Motocicleta", "Automóvil", "Dron" };

        public void TipoVehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehículos:");
            foreach (var item in tipos)
            {
                Console.WriteLine(item);
            }
        }

        public void ListadoVehiculos()
        {
            foreach(var item in tipos)
            {
                Console.WriteLine(item);

            }
        }

        public Boolean Existencia(string valor)
        {
            Boolean existe = tipos.Contains(valor);
            return existe;
        }

        public void ListaReportes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            List<String> tipos = new List<String>() { "Motocicleta", "Automóvil", "Dron" };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Estos son los tipos de vehículos:");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var item in tipos)
            {
                Console.WriteLine(item);
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
