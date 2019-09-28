using System;
using System.Collections.Generic;
using System.Text;

namespace T05._Areas_sobbrecarga_
{
    class CArea
    {
        public double Area(double a)
        {

            return  a*a;

        }

        public double Area(double a,double b)
        {
            return a * b;
        }

        public double Area(double a,double b,double c=2)
        {
            return a * b / c;

        }
    }
}
