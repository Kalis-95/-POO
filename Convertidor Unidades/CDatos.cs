using System;
using System.Collections.Generic;
using System.Text;

namespace Convertidor_Unidades
{
    class CDatos
    {

        //declamos  un metodo para pedir al usuario que ingrese los datos y asi empezar el calculo correspondiente 
        public void ObtenerDatos()
        {
            //instanciondo el objeto que sera utilizado en esta clase  
            CUnidad op = new CUnidad();

            int opcion = 0;

            

            //agregare un metodo do while en caso se que el usuario quiera hacer mas de un calculo en el programa
            do
            {

                //limpiar la pantalla cada que el usuario le de ala opcion de hacer una nueva operacion del menu inicial
                Console.Clear();


                //instruciones que se depleglaran el la pantalla para iteraccion con el usuario 
                Console.WriteLine("  Hola  Bienvenido ");
                Console.WriteLine("  Selecione una opcion del menu: ");
                Console.WriteLine("  1.- Convertir centimetros a metros: ");
                Console.WriteLine("  2.- Convertir metros a pulgadas ");
                Console.WriteLine("  3.- Convertir litros a mililitros ");

                //  se le asigna valor a la varieble para la opcion del menu
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese cantidad en centimetros ");
                    double cm = Convert.ToDouble(Console.ReadLine());
                    double res = op.Mtr(cm);
                    Console.WriteLine("  El resultado es " + " " + res+" Metros");


                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese Cantidad en Metros:");
                    double mts = Convert.ToDouble(Console.ReadLine());                  
                    double res = op.Plg(mts);
                    Console.WriteLine("  El resultado es " + " " + res+" Pulgadas");

                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Ingrese cantida en litros: ");
                    double ltrs = Convert.ToDouble(Console.ReadLine());
                    
                    double res = op.Mlltr(ltrs);
                    Console.WriteLine("  El resultado es " + " " + res+" mililitros");
                   
                }
                else
                {
                    Console.WriteLine("ERROR\nLA OPCION NO ES VALIDA");
                }


                Console.WriteLine("Quiere hacer otra operacion? \n1.-SI\n2.-NO ");
                opcion = int.Parse(Console.ReadLine());

            } while (opcion == 1);
        }

        
    }
}
