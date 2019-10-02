using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01._Calculadora
{
    class CPrincipal
    {
        //Instanciamos el valor V para que el usuario pueda elegir los numeros que quiera
        CValores V = new CValores();
        
        //een el siguiente metodo daremos la bienvenida al usario
        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido al program calculadora ");
           // Console.ReadKey();
        }
        public void Menu()
        {
            //deslegamos un menu para que el usuario elija una de las opciones y mas abajo agregare un metodo de seleccion
            Console.Write(" Seleccione una opcion del munu: \n\n\n 1.-Sumar \n 2.-Restar \n 3.-Multiplicar \n 4.-Dividir \n 5.-Salir   ");
            //Console.WriteLine("Que operacion quiere realizar:");
            //Console.WriteLine("1.-Sumar");
            //Console.WriteLine("2.-Restar");
            //Console.WriteLine("3.-Multiplicar");
            //Console.WriteLine("4.-Dividir");
            //Console.WriteLine("5.-Salir");

            //instanciamos el metodo de operaciones 
            //y declaramos la variable para el resutado
            double res;
            COperaciones op = new COperaciones();
            int n = Convert.ToInt32(Console.ReadLine());

            //el metodo switch es paa que en el menu el usuario eliga una de las opciones 
            switch (n)
            {
                case 1:
                    res = op.Suma(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 2:
                    res = op.Resta(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 3:
                    res = op.Multiplicar(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;


                case 4:
                    res = op.Division(V);
                    Console.WriteLine("La respues es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine("  ");
                    Menu();
                    break;

                case 5:
                    Console.WriteLine("Gracias vuelva pronto ");
                    Console.ReadKey();
                    Environment.Exit(0);
                    Console.ReadKey();
                    break;

                //el defaul sera con el proposito de que el usuario ingreshace lo que quierese cualquier ota cosa que no sea un numero (tonto usuario siempre hace lo que quiere 
                default:
                    Console.WriteLine("Introduzca uno de los 5 numeros");
                    Menu();
                    break;
            }
        }
        //ESta clase al usaremos para desplegar en pantalla intrucciones para el usuario como ingresar numeros 
        public void Valor()
        {

            Console.WriteLine("Ingrese el primer valor:");

            V.ValorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("  ");

            Console.WriteLine("Ingrese el segundo valor");

            V.ValorB = Convert.ToDouble(Console.ReadLine());

        }
    }
}
