using System;
using System.Security.Cryptography;


public class Cliente
{
    private string nombre;
    private string cedula;



    private int numeroFactura;
    private int entradas;
    private int localia;

    



    // Constructor de la clase
    public Cliente(string nombre, string cedula, int numeroFactura, int entradas, int localia)
    {
        this.nombre = nombre;
        this.cedula = cedula;
        this.numeroFactura = numeroFactura;
        this.entradas = entradas;
        this.localia = localia;

       


    }


    public void MostrarDatos()
    {
        Console.WriteLine("Nombre del Cliente: " + nombre);
        Console.WriteLine("Cedula: " + cedula);
    

        
    }


        public void Calculos()
        {

          if (entradas > 4)
          {
            entradas = 4;


          }

        int localias = localia;
            int espacios = entradas;
            int costoPago;
            int costoadicional = 1000;



            // Condiciones
            if (localias == 1)
            {
                int costodelocalia1 = 10500;
                costoPago = (int)(espacios * costodelocalia1);
                Console.WriteLine("Usted se encuentra en la localidad Sol Norte/Sur ");
                Console.WriteLine("El costo a pagar por entrada en esta localidad es de: " + costodelocalia1);


            }
            else if (localias == 2)
            {
                int costodelocalia2 = 20500;
                costoPago = (int)(espacios * costodelocalia2);
                Console.WriteLine("Usted se encuentra en la localidad  Sombra Este/Oeste ");
                Console.WriteLine("El costo a pagar por entrada en esta localidad es de: " + costodelocalia2);
            }


            else
            {
                int costodelocalia3 = 25500;
                costoPago = (int)(espacios * costodelocalia3);
                Console.WriteLine("Usted se encuentra en la localidad Preferencial ");
                Console.WriteLine("El costo a pagar por entrada en esta localidad es de: " + costodelocalia3);


            }


            // Cálculo del costo adicional por entrada
            int calculodetotaladicional = (int)(espacios * costoadicional);

            // Cálculo del pago total
            int totalpagar = calculodetotaladicional + costoPago;


            // Cálculo del subtotal
            int subtotal = totalpagar - calculodetotaladicional;


            Console.WriteLine("Costo adicional a pagar por entrada= " + calculodetotaladicional);
            Console.WriteLine("Subtotal a pagar sin costo adicional= " + subtotal);
            Console.WriteLine("Numero de Entradas Compradas= " + espacios);
            Console.WriteLine("NUmero de Factura= " + numeroFactura);
            Console.WriteLine("Total a pagar = " + totalpagar);




        }
    }


