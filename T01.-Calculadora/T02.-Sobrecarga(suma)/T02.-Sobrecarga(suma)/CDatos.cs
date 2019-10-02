using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02._Sobrecarga_suma_
{
    class CDatos
    {
        //declaramos un metodo para pedir al usuario que ingrese los datos 
        public void ObtenerDatos()
        {
            //desplegar en pantalla 
            COperaciones op = new COperaciones();
            Console.WriteLine("  Hola  Bienvenido ");

            //metodos para pedir los datos al los usuarios para las variables de suma
            Console.WriteLine("  Ingresa 2 datos numericos, pueden o no ser decimales: ");

            //se le pide ell primer dato al usuario y se le indica a que variable se le asignara 
            Console.WriteLine("  Dato 1: ");           
            double cool = Convert.ToDouble(Console.ReadLine());

            //sepide el segundo dato y se le asigna a la variable 
            Console.WriteLine("  Dato 2: ");
            double coo2 = Convert.ToDouble(Console.ReadLine());
            
            //se le asigna el valor que representara el resultado y se llama al objrto que realizara la opreacion
            double res = op.Sumar(cool, coo2);
            Console.WriteLine("     {0} + {1} = {2} ", cool, coo2, res);

            Console.WriteLine("  El resultado es " + " " + res);




        }
    }
}
