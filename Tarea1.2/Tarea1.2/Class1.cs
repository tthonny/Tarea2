using System;

public class Empleado
{
    private string nombre;
    private string cedula;
    private int horasTrabajadas;
    private int tipoEmpleado;
    private int precioxHora;


    double deduccionCCSS = 0.0915;




    // Constructor de la clase
    public Empleado(string nombre, string cedula, int horasTrabajadas, int tipoEmpleado, int precioxHora)
    {
        this.nombre = nombre;
        this.cedula = cedula;
        this.horasTrabajadas = horasTrabajadas;
        this.precioxHora = precioxHora;
        this.tipoEmpleado = tipoEmpleado;
    }

    
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Cedula: " + cedula);
        Console.WriteLine("Horas Trabajadas: " + horasTrabajadas);


    }

    public void Calculos()
    {
        // Cálculo del salario ordinario
        int salarioOrdinario = precioxHora * horasTrabajadas;

        int Aumento = tipoEmpleado;
        int salarioBruto;

        // Condiciones
        if (Aumento == 1)
        {
            double aumento1 = 0.15;
            int salarioBruto1 = (int)(salarioOrdinario * aumento1);
            Console.WriteLine("El aumento por Empleado Operario es del 15% a su salario seria: " + salarioBruto1);

            salarioBruto = salarioBruto1 + salarioOrdinario;
        }
        else if (Aumento ==2)
        {
            double aumento2 = 0.10;
            int salarioBruto2 = (int)(salarioOrdinario * aumento2);
            Console.WriteLine("El aumento por Empleado Tecnico es del 10% a su salario seria: " + salarioBruto2);
            salarioBruto = salarioBruto2 + salarioOrdinario;
        }


        else
        {
            double aumento3 = 0.05;
           int  salarioBruto3 = (int)(salarioOrdinario * aumento3);
            Console.WriteLine("El aumento por Empleado Profesional es del 5% a su salario seria: " + salarioBruto3);
            salarioBruto = salarioBruto3 + salarioOrdinario;






        }

       
         // Cálculo de la deducción de la CCSS
        int calculodeDeduccionCCSS = (int)(salarioBruto * deduccionCCSS);

        // Cálculo del salario neto después de deducción de la CCSS
        int SalarioNeto = salarioBruto - calculodeDeduccionCCSS;

        // Cálculo del salario por hora
        int SalarioporHora = salarioBruto / horasTrabajadas;

        
        Console.WriteLine("Salario Ordinario = " + salarioOrdinario);
        Console.WriteLine("Salario Bruto = " + salarioBruto);
        Console.WriteLine("Deducción de CCSS =  " + calculodeDeduccionCCSS);
        Console.WriteLine("Salario Neto = " + SalarioNeto);
        Console.WriteLine("Salario por Hora = " + SalarioporHora);
       



    }

}








