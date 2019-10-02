using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01._Calculadora
{
    class CValores
    {
        //Encapsulamos los valores en una clase
        private double id;
        private double valorA;
        private double valorB;

        public double ID
        {
            get { return id; }
            set { id = value; }
        }
        public double ValorA
        {
            get { return valorA; }
            set { valorA = value; }
        }
        public double ValorB
        {
            get { return valorB; }
            set { valorB = value; }
        }
    }
}
