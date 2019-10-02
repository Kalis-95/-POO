using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables 
            double res1 = 0, res2=0,res3=0;
            //mandamos a llamar el objeto de obtener datos 
            CDatos d = new CDatos();
            d.ObtenerDatos();
            

            //creamos el objeto de multiplicar para imprimir todos los metodos que sobrecargamos en la clase operaciones 
            COperaciones op = new COperaciones();

            Console.WriteLine("---------------------------------------");

            op.Multiplicar();
            res1 = op.Multiplicar(2, 3);
            Console.WriteLine("La respueta es " + " " + res1);
            res2 = op.Multiplicar(6);
            Console.WriteLine("La respueta es " + " " + res2);
            res3 = op.Multiplicar();
            Console.WriteLine("La respueta es " + " " + res3);

            Console.ReadKey();

          









        }
    }
}
