using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02._Sobrecarga_suma_
{
    public class COperaciones
    {
        //metodos de sobre cargo es cuando tenemos varios metodos con el mismo nombre, lo que los hace diferentes es el tipo y/o la cantidad
        // de los datos que contiene para realizar la funcion 

        //declaramos metodos 

        //metodo sumar con dos variables tipo double 

        public double Sumar (double a, double b)
        {

            return a + b;

        }

        //metodo de sumar con una variable y un constante establecida 

        public double Sumar (double a)
        {
            return a + 8;

        }

        // metodo de sumar  sin parametros, es decir el usuario establecera el tipo y la cantidad de variables que desea utilizar  
        public double Sumar ()
        {
            return 8 + 9;

        }
    }
}
