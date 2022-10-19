using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Examen_Progra_2___Alexander_Montero
{
    static class Menu
    {
        static Menu() { }

        public static void Principal()
        {
      
            byte opcion = 1;
            do
            {
                Console.SetCursorPosition(35, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("¡Bienvenido al centro de ventas de vehículos Monteva!\n\n");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********** Menu Principal **********");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vehículos");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ventas");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Reportes");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("4 - ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: SubMenuVehiculos(); break;
                    case 2: SubMenuVentas(); break;
                    case 3: SubMenuReportes(); break;
                    case 4:
                        Console.SetCursorPosition(50, 10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gracias por preferirnos...");
                        break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }

        public static void SubMenuVehiculos()
        {
            int codigo = 0;
            string marca = "";
            float costo = 0;
            string modelo = "";
            byte opcion = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Vehiculos ********");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Agregar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Modificar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Consultar");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("4 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("****************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: Vehiculos.AgregarVehiculos(); break;
                    case 2: Vehiculos.ModificarVehiculo(codigo, marca, costo, modelo); break;
                    case 3: Vehiculos.Consulta(); break;
                    case 4:Menu.Principal(); break;
                    default:
                        break;
                }
            } while (opcion != 4);

        }

        public static void SubMenuVentas()
        {
            Vendedor vd = new Vendedor();
            Tipo tp = new Tipo();
            byte opcion = 1;
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Ventas ********");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Código Vehículo");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Código Vendedor");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Vehiculos.Consulta();
                        //tp.ListadoVehiculos();
                        break;
                    case 2:
                        vd.ListadoVendedores(); 
                        
                        break;
                    case 3:Menu.Principal(); break;
                    default:
                        break;
                }
            } while (opcion != 3);
        }

        public static void SubMenuReportes()
        {
            Vendedor vd = new Vendedor();
            Tipo tp = new Tipo();
            byte opcion = 1;

            do
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Reportes ********");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Todos los vendedores");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tipos");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Vehículos ingresados");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("4 - ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("****************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: vd.VendedoresReportes(); break;
                    case 2: tp.ListaReportes(); break;
                    case 3: Vehiculos.Reportes(); break;
                    case 4:  break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }
    }
}

