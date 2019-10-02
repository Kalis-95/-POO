using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01._Calculadora
{
    class COperaciones
    {
        //Declaramos res globalmente para que las operacion tenga una variable para el resultado
        double res;
        //Hacemos sus respectivos metodos de cada operacion 
        public double Suma(CValores V)

        {

            res = V.ValorA + V.ValorB;
            return res;

        }
        public double Resta(CValores V)

        {
            res = V.ValorA - V.ValorB;
            return res;

        }
        public double Multiplicar(CValores V)

        {
            res = V.ValorA * V.ValorB;
            return res;

        }
        public double Division(CValores V)

        {
            res = V.ValorA / V.ValorB;
            return res;

        }
    }
}
