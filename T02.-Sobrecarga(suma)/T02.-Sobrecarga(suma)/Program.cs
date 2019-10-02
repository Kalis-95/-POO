using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02._S//declarar variables 
            double res1 = 0, res2 = 0, res3 = 0;
            //mandamos a llamar el objeto de obtener datos 
            CDatos d = new CDatos();
            d.ObtenerDatos();


            //creamos el objeto de sumar para imprimir todos los metodos que sobrecargamos en la clase operaciones 
            COperaciones op = new COperaciones();

            Console.WriteLine("---------------------------------------");
            //despliegue de resultados en pantalla 
            //En esta parte se desplegara un ejemplo de cada una de las sobre cargas que integramos al programa
            //los valores ya esta dis puestos en el programa y por lo pronto no son para iteractuar con el usuario
            //mas adelante el programa sera actualizado para que el usuari decida cuantos datos desea ejecuatar 
            op.Sumar();
            res1 = op.Sumar(2, 3);
            Console.WriteLine("La respueta es " + " " + res1);
            res2 = op.Sumar(6);
            Console.WriteLine("La respueta es " + " " + res2);
            res3 = op.Sumar();
            Console.WriteLine("La respueta es " + " " + res3);

            //fin del program sobre carga de sumas 
            Console.ReadKey();obrecarga_suma_
{
    class Program
    {
        static void Main(string[] args)
        {
            


        }
    }
}
