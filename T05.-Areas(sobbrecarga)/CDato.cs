using System;
using System.Collections.Generic;
using System.Text;

namespace T05._Areas_sobbrecarga_
{
    class CDato
    {
        //declamos  un metodo para pedir al usuario que ingrese los datos y asi empezar el calculo del area correspondiente 
        public void ObtenerDatos()
        {
            //instanciondo el objeto que sera utilizado en esta clase  
            CArea op = new CArea();

            int opcion = 0;

            //int opcion = 0;, lad = 0, alt = 0, res = 0;
            //double lad1 = 0, alt2 = 0, bas = 2;

            //agregare un metodo do while en caso se que el usuario quiera hacer mas de un calculo en el programa
            do
            {
                //limpiar la pantalla cada que el usuario regrese al menu inicial
                Console.Clear();


                //instruciones que se depleglaran el la pantalla para iteraccion con el usuario 
                Console.WriteLine("  Hola  Bienvenido ");
                Console.WriteLine("  Selecione una opcion del menu:");
                Console.WriteLine("  1.- Area de cuadrado: ");
                Console.WriteLine("  2.- Area de rectangulo: ");
                Console.WriteLine("  3.- Area de triangulo ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("ingrese medida del lado: ");
                    double lad = Convert.ToDouble(Console.ReadLine());
                    double res = op.Area(lad);
                    Console.WriteLine("  El resultado es " + " " + res);


                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese la medida de la base:");
                    double lad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la medida de la altura:");
                    double lad1 = Convert.ToDouble(Console.ReadLine());
                    double res = op.Area(lad, lad1);
                    Console.WriteLine("  El resultado es " + " " + res);

                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Ingrese la medida de la base:");
                    double lad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la medida de la altura:");
                    double lad1 = Convert.ToDouble(Console.ReadLine());
                    double res = op.Area(lad, lad1);
                    Console.WriteLine("  El resultado es " + " " + res / 2);
                    //NOTA: esta operacion no puede llamar en metodo con tres variables, asi que llame el de dos y el resulta 
                            //lo dividi al mometo de desplegarlo en pantalla
                }
                else
                {
                    Console.WriteLine("ERROR\nLA OPCION NO ES VALIDA");
                }


                Console.WriteLine("Quiere hacer otra operacion? \n1.-SI\n2.-NO ");
                opcion = int.Parse(Console.ReadLine());

            } while (opcion == 1);







            //Console.WriteLine("  Inngresa 2 datos numericos, pueden o no ser decimales: ");
            //Console.WriteLine("  Dato 1: ");


            //double cool = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("  Dato 2: ");
            //double coo2 = Convert.ToDouble(Console.ReadLine());

            //double res = op.Area(cool, coo2);
            //Console.WriteLine("     {0} * {1} = {2} ", cool, coo2, res);

            //Console.WriteLine("  El resultado es " + " " + res);




        }
    }
}
