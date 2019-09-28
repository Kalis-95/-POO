using System;

namespace T04._Metodo_out
{
    class Program
    {
        //iniciando el metodo out con los parametros correspondientes 

        static void Cambio(out int pesos,out int cent)
        {
            //variables que quedaran dentro del metodo 
            int peso = 100, centavo=100, n3 = 0;
            //operacion para cambiar de pesos acentavos con el valor de la variable ya establecida en el programa por lo pronto
            //no tendre iteraccion con el usuario y quedara solo como ejecutable 
            cent = peso * 100;
            //operacion para calcular de cetavos a pesos con las mismas condiciones anteriores
            pesos = centavo / 100;
        }
        
        //programa principal en donde se lllamara al metodo
        static void Main(string[] args)
        {
            //variables para indicar los parametros que seran utilizados para ejecutar el metodo 
            int totalcent = 0;
            int totalpeso = 0;

            //ejecutando el metodo dentro del main para desplegar en pantalla el resultado final
            Cambio(out totalpeso, out totalcent);
            Console.WriteLine("El cambio a pesos es: " + totalpeso);
            Console.WriteLine("el cambio a centavos es : " + totalcent);
            //fin del programa metodo
            Console.ReadKey();


        }
    }
}
