using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Progra_2___Alexander_Montero
{

    internal class Vendedor2 : Ivendedor2
    {
        public void VentasCredito()
        {
            string linea;
            float precio;
            double total;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nIngrese el precio de la venta a crédito del vehiculo:");
            Console.ForegroundColor = ConsoleColor.Blue;
            linea = Console.ReadLine();
            precio = float.Parse(linea);
            Console.WriteLine("Se cobrará un interés del 11% del precio de la venta.");
            total = precio + (precio * 0.03);
            total = Math.Round(total);
            Console.WriteLine("El total de la venta redondeada es: " + total + ".");
        }
    }
}
