using System;

namespace Convertidor_Unidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables 
           // double res1 = 0, res2 = 0, res3 = 0;   NOTA no fue necesario declarar variables.
            //mandamos a llamar el objeto de obtener datos 
            CDatos d = new CDatos();
            d.ObtenerDatos();


          

            //creamos el objeto de unidades para imprimir todos los metodos de la clase operaciones 
            //CUnidad op = new CUnidad();
            //Console.ReadLine();
        }
    }
}
