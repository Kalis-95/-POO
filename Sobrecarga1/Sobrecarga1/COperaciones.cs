using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga1
{
    //esta clase esta establecida por el programador y la hacemos publica para que las otras clases puedan acceder a ella 
    public class COperaciones
    {
        //metodos de sobre cargo es cuando tenemos varios metodos con el mismo nombre, lo que los hace diferentes es el tipo y/o la cantidad
        // de los datos que contiene para realizar la funcion 

            //declaramos metodos 

            //metodo muliplicar con dos variables tipo double 
        public double Multiplicar(double a, double b)
        {

            return a * b;

        }

        //metodo de multiplicar con una variable y un constante establecida 
        public double Multiplicar(double a )
        {
            return a*8;

        }

        // metodo de multiplicar sin parametros, es decir el usuario establecera el tipo y la cantidad de variables que desea utilizar 
        public double Multiplicar()
        {
            return 8*9;

        }

    }
}
