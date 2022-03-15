using System;

namespace TodoSobreMetodos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a todo sobre metodos.");
            int Opcion=0;
           do
           {
               Console.WriteLine("Que deseas hacer");
               Console.WriteLine("Opcion 0 salir");
               Console.WriteLine("Opcion 1 imprimir nombre");
               Console.WriteLine("Opcion 2 sumar");
               Console.WriteLine("Opcion 3 multiplicar");
               Opcion= int.Parse(Console.ReadLine());
               if(Opcion==1)
               {
                  string nombre= FundamentosMetodos.getnombre();
                  Console.WriteLine(nombre);

               }
               else if(Opcion==2)
               {
                   int num1= 5;
                   int num2= 8;
                   int suma= FundamentosMetodos.sumar(num1,num2);
                   Console.WriteLine("La suma es:"+ suma);

                }
                else if(Opcion==3)
                {
                    int mul= 2;
                    int mul2= 3;
                    int mul3= 6;
                    int multiplicacion= FundamentosMetodos.multiplicar(mul,mul2,mul3);
                    Console.WriteLine("La multiplicacion es:"+multiplicacion);
                }

           }
           while(Opcion==0);

        }
    }
}
