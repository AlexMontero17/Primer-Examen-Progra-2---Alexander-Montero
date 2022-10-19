using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Progra_2___Alexander_Montero
{
    internal class Vendedor
    {
        public void ListadoVendedores()
        {
            Vendedor1 vd1 = new Vendedor1();
            Vendedor2 vd2 = new Vendedor2();
            string linea;
            int vend;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esta es la lista de los vendedores de la empresa:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Dictionary<int, string> nombre = new Dictionary<int, string>();
            nombre.Add(1, "Juan Perez");
            nombre.Add(2, "Pedro Castillo");
            foreach (KeyValuePair<int, string> persona in nombre)
            {
                Console.WriteLine("El vendedor número " + persona.Key + " se llama " + persona.Value + ".");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPor favor ingresar número del vendedor que lo atendió:");
            Console.ForegroundColor = ConsoleColor.Blue;
            linea = Console.ReadLine();
            vend = int.Parse(linea);

            if (vend == 1 || vend == 2)
            { 
                if (vend == 1)
                {
                Console.WriteLine("Fue atendido por el vendedor número " + vend + " con el nombre de " + nombre[vend] + ".");
                vd1.VentasContado();
                }
                else
                {
                Console.WriteLine("Fue atendido por el vendedor número " + vend + " con el nombre de " + nombre[vend] + ".");
                vd2.VentasCredito();
                }
            }
            else
            {
                Console.WriteLine("\nEse número no corresponde a ningún vendedor.");
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al submenu");
            Console.ReadKey();
            Console.Clear();
        }

        public void VendedoresReportes()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esta es la lista de los vendedores de la empresa:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Dictionary<int, string> nombre = new Dictionary<int, string>();
            nombre.Add(1, "Juan Perez");
            nombre.Add(2, "Pedro Castillo");
            foreach (KeyValuePair<int, string> persona in nombre)
            {
                Console.WriteLine("El vendedor número " + persona.Key + " se llama " + persona.Value + ".");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pulse una tecla para volver al submenu");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
