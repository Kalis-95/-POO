using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    //esta clase es definida por el programador 
    class CDatos
    {
        //declaramos un metodo para pedir al usuario que ingrese los datos 
        public void ObtenerDatos()
        {
            //desplegar en pantalla 
            COperaciones op = new COperaciones();
            Console.WriteLine("  Hola  Bienvenido ");
            Console.WriteLine("  Inngresa 2 datos numericos, pueden o no ser decimales: ");
            Console.WriteLine("  Dato 1: ");


            double cool = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("  Dato 2: ");
            double coo2 = Convert.ToDouble(Console.ReadLine());

            double res = op.Multiplicar(cool, coo2);
            Console.WriteLine("     {0} * {1} = {2} ", cool, coo2, res);

            Console.WriteLine("  El resultado es " + " " + res);

            


        }
    }
}
