using System;
using System.Collections.Generic;
using System.Text;

namespace Convertidor_Unidades
{
    class CUnidad
    {

        //double mtr = 0, plg = 0, mllitr = 0;

        //public double Mtr { get; set; }

        //public double Plg { get; set; }

        //public double Mlltr { get; set; }

        public double Mtr(double a)
        {

            return a / 100;

        }

        public double Plg(double a)
        {
            return a * 39.37;
        }

        public double Mlltr(double a)
        {
            return a * 1000;

        }


        public CUnidad()
        {
            Console.WriteLine("este es eel constructor");

        }
    }
   
}
