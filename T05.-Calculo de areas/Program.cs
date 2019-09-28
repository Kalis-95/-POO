using System;

namespace T05._Calculo_de_areas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, area = 0;

            do
            {
                Console.Clear();
                //desplegar menu de opciones en pantalla para la seleccion del usuario 
                Console.WriteLine("seleccione una opocion del menu:\n1.-Area de cuadrado\n2.-Area de rectangulo" +
                    "\n3.-Area de triangulo.");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)//opcion para ejecuatar el area del cuadrado 
                {
                    cuadrado(out area);
                    Console.WriteLine(" El area del cuadrado es: " + area);

                }
                else if (opcion == 2)//opcion para ehjecutar el area del rectangulo
                {
                    rectangulo(out area);
                    Console.WriteLine(" El area del cuadrado es: " + area);
                }
                else if (opcion == 3)//opcion para ejecutar el area de triangulo
                {
                    triangulo(out area);
                    Console.WriteLine(" El area del cuadrado es: " + area);
                }
                Console.WriteLine("Quiere calcular otra area?\n1.-SI\n2.-NO");
                opcion = int.Parse(Console.ReadLine());

            } while (opcion == 1);
            Console.ReadLine();
        }



        //metodos para calcular las areas dde las diferntes figuras dependiendo de eleccion del ususario 
        static void cuadrado(out int area)
        {
            int lado = 0;
            Console.WriteLine("ingrese medida de lado: ");
            lado = int.Parse(Console.ReadLine());
            area = lado * lado;
        }
        static void rectangulo(out int area)
        {
            int lado = 0, altura = 0;
            Console.WriteLine("ingrese medida de base: ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese mediada de altura: ");
            altura = int.Parse(Console.ReadLine());
            area = lado * altura;
        }
        static void triangulo(out int area)
        {
            int lado = 0, altura = 0;
            Console.WriteLine("ingrese medida de base: ");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese mediada de altura: ");
            altura = int.Parse(Console.ReadLine());
            area = lado * altura / 2;
        }
    }
}
