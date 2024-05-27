using System;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = null; // Declarar la variable fuera del switch

            int num;
            string linea;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione qué acción desea realizar: ");
                Console.WriteLine("1 - Ingresar Datos");
                Console.WriteLine("2 - Mostrar Datos");
                Console.WriteLine("3 - Salir");
                Console.Write("Ingrese un número del 1 al 3: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);

                switch (num)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Ingresar Datos");
                        
                        Console.WriteLine("Ingrese el nombre del empleado:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese la cedula del empleado:");
                        string cedula = Console.ReadLine();

                        Console.WriteLine("Ingrese el tipo de empleado de empleado 1)Empleado Operario 2)Empleado Tecnico 3)Empleado Profesional:");
                        int tipoEmpleado;
                        while (!int.TryParse(Console.ReadLine(), out tipoEmpleado))
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }

                        Console.WriteLine("Ingrese las horas laboradas:");
                        int horasTrabajadas;
                        while (!int.TryParse(Console.ReadLine(), out horasTrabajadas))
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }

                        Console.WriteLine("Ingrese el pago por horas laboradas:");
                        int precioxHora;
                        while (!int.TryParse(Console.ReadLine(), out precioxHora))
                        {
                            Console.WriteLine("Ingrese un numero valido.");
                        }


                        
                        empleado = new Empleado(nombre,cedula,horasTrabajadas,tipoEmpleado,precioxHora);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Mostrar Datos");
                        if (empleado != null)
                        {
                            Console.WriteLine("\nDatos del Empleado:");
                           empleado.MostrarDatos();
                           empleado.Calculos();
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
