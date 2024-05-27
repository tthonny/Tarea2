using System;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = null; // Declarar la variable fuera del switch

            int num;
            int numeroFactura = 11110;
            string linea;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("BIENVENIDO AL SISTEMA DE COMPRAS DEL ESTADIO");


                Console.WriteLine("Seleccione qué acción desea realizar: ");
                Console.WriteLine("1 - Realizar Compra de Entradas");
                Console.WriteLine("2 - Ver Compra");
                Console.WriteLine("3 - Salir");
                Console.Write("Ingrese un número del 1 al 3: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);

                switch (num)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Ingresar Datos");

                        Console.WriteLine("Ingreses su nombre :");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese la cedula:");
                        string cedula = Console.ReadLine();

                        // Console.WriteLine("Numero de Factura:" + numeroFactura++);


                        Console.WriteLine("Ingrese la cantidad de entradas que desea comprar");
                        Console.WriteLine("ADVERTENCIA SI COMPRA MAS DE 4 ENTRADAS EL SISTEMA DETECTARA ESTO Y LE PERMITIRA COMPRAR COMO MAXIMO 4 ENTRADAS");

                        int entradas;

                          while (!int.TryParse(Console.ReadLine(), out entradas))
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }

           
                        Console.WriteLine("Ingrese la localidad que desea comprar 1)Sol Norte/Sur  2)Sombra Este/Oeste  3)Preferencial) :");
                        int localia;
                        while (!int.TryParse(Console.ReadLine(), out localia))
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }



                        cliente = new Cliente(nombre, cedula, numeroFactura, entradas, localia);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Mostrar Datos");
                        if (cliente != null)
                        {
                            Console.WriteLine("\nFactura de la compra:" + numeroFactura++);
                            cliente.MostrarDatos();
                            cliente.Calculos();
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar datos primero.");
                        }
                        break;

                    case 3:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("El número que ingresó está fuera de rango");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
                
                Console.Clear();
            }
        }
    }
}

