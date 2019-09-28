using System;

namespace T05._Areas_sobbrecarga_
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables 
            double res1 = 0, res2 = 0, res3 = 0;
            //mandamos a llamar el objeto de obtener datos 
            CDato d = new CDato();
            d.ObtenerDatos();
            

            //creamos el objeto de multiplicar para imprimir todos los metodos que sobrecargamos en la clase operaciones 
            CArea op = new CArea();
            Console.ReadLine();
        }
    }
}
