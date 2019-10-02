using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01._Calculadora
{
    class Program
    {
        //este es el programa principal en donde se ejecutaran todas las clases 
        static void Main(string[] args)
        {
            //Mandamos a llamar a los metodos
            CPrincipal op = new CPrincipal();
            op.Bienvenida();
            Console.WriteLine("   ");
            op.Valor();
            Console.WriteLine("   ");
            op.Menu();
        }
    }
}
